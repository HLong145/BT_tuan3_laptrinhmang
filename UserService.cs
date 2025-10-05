using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography; 
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FormDNDK
{
    public class UserService
    {   
        // ========================================
        // DÒNG NÀY CẦN CẬP NHẬT SAU KHI TẠO DB NHÁ
        // ========================================
        private readonly string connectionString = "Server=localhost;Database=UserDB;Integrated Security=True;";

        // ================================
        // 🧩 1. Kiểm tra hợp lệ đầu vào 
        // ================================

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_\-+=\[\]{};:'"",.<>/?\\|`~]).{8,}$");
        }

        // ================================
        // 🧩 2. Hash & Verify mật khẩu 
        // ================================

        // Tạo một chuỗi Salt ngẫu nhiên
        public string CreateSalt()
        {
            // Tạo 16 bytes dữ liệu ngẫu nhiên
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            // Chuyển sang chuỗi Base64 để lưu vào DB. Base64 là tốt cho Salt.
            return Convert.ToBase64String(saltBytes);
        }

        // Hash mật khẩu bằng SHA-256 kèm theo Salt
        public string HashPassword_Sha256(string password, string salt)
        {
            // Kết hợp mật khẩu và Salt trước khi Hash
            string saltedPassword = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                // Hash byte[] của chuỗi đã thêm Salt
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString(); // Chuỗi 64 ký tự hex
            }
        }

        // Hàm kiểm tra mật khẩu khi đăng nhập
        public bool VerifyPassword_Sha256(string password, string storedHash, string storedSalt)
        {
            // Hash lại mật khẩu người dùng nhập vào bằng Salt đã lưu
            string newHash = HashPassword_Sha256(password, storedSalt);

            // So sánh hai chuỗi Hash
            return string.Equals(newHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }

        // ================================
        // 🧩 3. Database Helpers 
        // ================================

        // Kiểm tra tồn tại 
        public bool IsUserExists(string username, string emailOrNull, string phoneOrNull)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT COUNT(*) FROM Users 
                        WHERE Username = @Username
                        OR (Email IS NOT NULL AND Email = @Email)
                        OR (Phone IS NOT NULL AND Phone = @Phone)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", (object)emailOrNull ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Phone", (object)phoneOrNull ?? DBNull.Value);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tồn tại user: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        // Lưu dữ liệu của người dùng vào DB 
        public bool SaveUserToDatabase(string username, string emailOrNull, string phoneOrNull, string passwordHashStored, string saltStored)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Users (Username, Email, Phone, PasswordHash, Salt)
                        VALUES (@Username, @Email, @Phone, @PasswordHash, @Salt)"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", (object)emailOrNull ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Phone", (object)phoneOrNull ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHashStored);
                        cmd.Parameters.AddWithValue("@Salt", saltStored); 
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu user: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // ========================================
        // 🧩 4. OTP (không cần lưu DB)
        // ========================================

        private static Dictionary<string, (string Otp, DateTime ExpireAt, int Attempts)> otpStorage = new();

        public string GenerateOtp(string username)
        {
            string otp = new Random().Next(100000, 999999).ToString(); // 6 chữ số
            otpStorage[username] = (otp, DateTime.Now.AddMinutes(3), 0); // 3 phút hết hạn
            return otp;
        }

        public bool VerifyOtp(string username, string inputOtp)
        {
            if (!otpStorage.ContainsKey(username))
                return false;

            var (otp, expire, attempts) = otpStorage[username];

            // Quá 3 lần nhập sai
            if (attempts >= 3)
            {
                otpStorage.Remove(username);
                MessageBox.Show("Bạn đã nhập sai OTP quá 3 lần!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Hết hạn
            if (DateTime.Now > expire)
            {
                otpStorage.Remove(username);
                MessageBox.Show("OTP đã hết hạn. Vui lòng gửi lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // Đúng OTP
            if (otp == inputOtp)
            {
                otpStorage.Remove(username); // Xóa luôn sau khi dùng
                return true;
            }

            // Sai OTP → tăng số lần nhập sai
            otpStorage[username] = (otp, expire, attempts + 1);
            MessageBox.Show($"OTP sai ({attempts + 1}/3).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        // ========================================
        // 🧩 5. Reset mật khẩu người dùng
        // ========================================

        public bool ResetPassword(string username, string newPassword)
        {
            try
            {
                // Tạo salt và hash mới
                string newSalt = CreateSalt();
                string newHash = HashPassword_Sha256(newPassword, newSalt);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET PasswordHash=@Hash, Salt=@Salt WHERE Username=@Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Hash", newHash);
                        cmd.Parameters.AddWithValue("@Salt", newSalt);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reset mật khẩu: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // ========================================
        // 🧩 6. Kiểm soát số lần nhập sai mật khẩu
        // ========================================

        private static Dictionary<string, (int Attempts, DateTime LastAttempt)> loginAttempts = new();

        public bool CheckLoginAttempts(string username)
        {
            if (!loginAttempts.ContainsKey(username))
                return true; 

            var (attempts, last) = loginAttempts[username];

            // Nếu bị khóa <5 phút trước → chặn
            if (attempts >= 5 && (DateTime.Now - last).TotalMinutes < 5)
            {
                MessageBox.Show("Tài khoản bị khóa tạm thời 5 phút do nhập sai quá nhiều.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void RecordLoginAttempt(string username, bool success)
        {
            if (success)
            {
                // Reset nếu đăng nhập thành công
                if (loginAttempts.ContainsKey(username))
                    loginAttempts.Remove(username);
                return;
            }

            if (!loginAttempts.ContainsKey(username))
                loginAttempts[username] = (1, DateTime.Now);
            else
            {
                var (attempts, _) = loginAttempts[username];
                loginAttempts[username] = (attempts + 1, DateTime.Now);
            }
        }

    }
}
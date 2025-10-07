using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDNDK
{
    public partial class FormQuenMatKhau : Form
    {
        private readonly UserService _userService;

        public FormQuenMatKhau()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        // Nút quay lại đăng nhập
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút "TIẾP TỤC"
        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            string input = tb_ten.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập email hoặc số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định kiểu nhập: email hay số điện thoại
            bool isEmail = _userService.IsValidEmail(input);
            bool isPhone = _userService.IsValidPhone(input);

            if (!isEmail && !isPhone)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email hoặc số điện thoại!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string username = GetUsernameByContact(input);

                if (username == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản nào khớp với thông tin này!", "Không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sinh OTP
                string otp = _userService.GenerateOtp(username);

                MessageBox.Show($"Mã OTP của bạn là: {otp}\n(Chỉ hiển thị để test, sau này sẽ gửi qua email/SMS.)",
                                "OTP được tạo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form xác thực OTP
                FormXacThucOTP formOtp = new FormXacThucOTP(username);
                formOtp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUsernameByContact(string contact)
        {
            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(
                    "Server=localhost;Database=USERDB;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    conn.Open();

                    // ✅ SỬA: Đổi từ "Users" thành "NGUOIDUNG"
                    // ✅ SỬA: Đổi từ "Username", "Email", "Phone" thành chữ hoa
                    string query = _userService.IsValidEmail(contact)
                        ? "SELECT USERNAME FROM NGUOIDUNG WHERE EMAIL = @Contact"
                        : "SELECT USERNAME FROM NGUOIDUNG WHERE PHONE = @Contact";

                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn người dùng: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thêm kiểm tra realtime
        }
    }
}
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
    public partial class FormDangNhap : Form
    {
        private readonly UserService userService = new UserService();
        public FormDangNhap()
        {
            InitializeComponent();
            LoadRememberedLogin();
        }
        private void LoadRememberedLogin()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                tb_sdtmail.Text = Properties.Settings.Default.SavedUsername;
                tb_pass.Text = Properties.Settings.Default.SavedPassword;
                cb_remember.Checked = true;
            }
        }

        private void SaveRememberedLogin(string username, string password)
        {
            if (cb_remember.Checked)
            {
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.SavedUsername = username;
                Properties.Settings.Default.SavedPassword = password;
            }
            else
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.SavedUsername = "";
                Properties.Settings.Default.SavedPassword = "";
            }

            Properties.Settings.Default.Save();
        }

        public void LoadLoginAfterLogout()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                tb_sdtmail.Text = Properties.Settings.Default.SavedUsername;
                tb_pass.Text = Properties.Settings.Default.SavedPassword;
                cb_remember.Checked = true;
            }
            else
            {
                tb_sdtmail.Text = "";
                tb_pass.Text = "";
                cb_remember.Checked = false;
            }
        }

        public void ClearPassword()
        {
            tb_pass.Text = string.Empty;
            tb_sdtmail.Text = string.Empty;
        }
        private void btn_taotk_Click(object sender, EventArgs e)
        {
            FormDangKy fDK = new FormDangKy();
            this.Hide();
            fDK.ShowDialog();
            this.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string input = tb_sdtmail.Text.Trim();
            string password = tb_pass.Text;

            // Kiểm tra Captcha
            if (!cb_captcha.Checked)
            {
                MessageBox.Show("Vui lòng xác nhận bạn không phải robot!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trống
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định loại thông tin
            string username = input;
            bool isEmail = userService.IsValidEmail(input);
            bool isPhone = userService.IsValidPhone(input);

            // Nếu là email hoặc phone, tìm username tương ứng
            if (isEmail || isPhone)
            {
                username = GetUsernameByContact(input, isEmail);

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Không tìm thấy tài khoản với thông tin này!",
                        "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Xác thực đăng nhập
            bool loginSuccess = userService.VerifyUserLogin(username, password);

            if (loginSuccess)
            {
                SaveRememberedLogin(username, password);
                MessageBox.Show("Đăng nhập thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormXacNhanDangNhapThanhCong formXacNhan = new FormXacNhanDangNhapThanhCong();
                this.Hide();
                formXacNhan.ShowDialog();
                this.Close();
            }
        }


        private string GetUsernameByContact(string contact, bool isEmail)
        {
            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(
                    "Server=localhost;Database=USERDB;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    // ✅ SỬA: Đổi từ "Users" thành "NGUOIDUNG"
                    // ✅ SỬA: Đổi từ "Username" thành "USERNAME"
                    string query = isEmail
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
                MessageBox.Show("Lỗi kết nối database: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btn_forgotpass_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            this.Hide();
            formQuenMatKhau.ShowDialog();
        }

    }
}
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
                    "Server=localhost;Database=UserDB;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = isEmail
                        ? "SELECT Username FROM Users WHERE Email = @Contact"
                        : "SELECT Username FROM Users WHERE Phone = @Contact";

                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        var result = cmd.ExecuteScalar();
                        return result.ToString();
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
            this.Show();
        }
    }
}

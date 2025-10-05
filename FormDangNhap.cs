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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cb_captcha_CheckedChanged(object sender, EventArgs e)
        {

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

            // 🧩 1. Kiểm tra Captcha
            if (!cb_captcha.Checked)
            {
                MessageBox.Show("Vui lòng xác nhận bạn không phải robot!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧩 2. Kiểm tra trống
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧩 3. Xác định loại thông tin (email hay số điện thoại)
            bool isEmail = userService.IsValidEmail(input);
            bool isPhone = userService.IsValidPhone(input);

            if (!isEmail && !isPhone)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email hoặc số điện thoại!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🧩 4. Kiểm tra độ mạnh mật khẩu
            if (!userService.IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ!\nPhải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧩 5. Hash mật khẩu để test (ví dụ mô phỏng)
            string salt = userService.CreateSalt();
            string hashedPassword = userService.HashPassword_Sha256(password, salt);

            // (Hiển thị để kiểm tra logic hoạt động đúng)
            MessageBox.Show($"✅ Định dạng hợp lệ!\n\n" +
                            $"Loại: {(isEmail ? "Email" : "Số điện thoại")}\n" +
                            $"Salt: {salt}\n" +
                            $"Hash: {hashedPassword.Substring(0, 32)}...",
                            "Kết quả kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🧩 6. (Tạm thời dừng ở đây — chưa kết nối DB)
            // Sau này sẽ thêm: kiểm tra DB + VerifyPassword + điều hướng form
        }

        private void btn_forgotpass_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.Show();
        }
    }
}

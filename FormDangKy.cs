using System;
using System.Windows.Forms;

namespace FormDNDK
{
    public partial class FormDangKy : Form
    {
        private readonly UserService userService = new UserService();

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btn_formdn_Click(object sender, EventArgs e)
        {
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
            this.Close(); // Đóng form đăng ký
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string username = tb_ten.Text.Trim();
            string contact = tb_sdtmail.Text.Trim();
            string password = tb_pass.Text;
            string confirm = tb_passok.Text;

            // --- [1. Kiểm tra đầu vào] --- 
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }


            // Kiểm tra các trường trống
            if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Vui lòng nhập Email hoặc Số điện thoại!");
                return;
            }
            if (!cb_captcha.Checked)
            {
                MessageBox.Show("Vui lòng xác minh captcha!");
                return;
            }

            // Kiểm tra định dạng Email/Phone
            bool isEmail = userService.IsValidEmail(contact);
            bool isPhone = userService.IsValidPhone(contact);
            if (!isEmail && !isPhone)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email hoặc Số điện thoại.");
                return;
            }

            // Kiểm tra độ mạnh mật khẩu
            if (!userService.IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu yếu. Cần ít nhất 8 ký tự gồm chữ hoa, thường, số và ký tự đặc biệt.");
                return;
            }

            // Kiểm tra mật khẩu xác nhận
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!");
                return;
            }

            // Kiểm tra user/email/phone đã tồn tại chưa
            if (userService.IsUserExists(username, isEmail ? contact : null, isPhone ? contact : null))
            {
                MessageBox.Show("Tên đăng nhập hoặc Email/Số điện thoại đã tồn tại!");
                return;
            }

            // --- [2. Tạo Salt & Hash Mật Khẩu] ---
            string newSalt = userService.CreateSalt(); // Tạo Salt ngẫu nhiên
            string storedHash = userService.HashPassword_Sha256(password, newSalt); // Hash kèm theo Salt

            // --- [3. Lưu vào DB] ---
            bool ok = userService.SaveUserToDatabase(
                username,
                isEmail ? contact : null,
                isPhone ? contact : null,
                storedHash,
                newSalt
            );

            if (ok)
            {
                MessageBox.Show("Đăng ký thành công!");
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi lưu dữ liệu. Vui lòng thử lại.");
            }
        }
    }
}
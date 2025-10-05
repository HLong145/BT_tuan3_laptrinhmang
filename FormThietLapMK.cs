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
    public partial class FormThietLapMK : Form
    {
        private readonly string _username;
        private readonly UserService _userService;

        // ✅ Constructor có tham số — để nhận username từ FormXacThucOTP
        public FormThietLapMK(string username)
        {
            InitializeComponent();
            _username = username;
            _userService = new UserService();

            // Gắn sự kiện click cho nút HOÀN TẤT
            btn_dangky.Click += btn_dangky_Click;
        }

        // Constructor mặc định (Visual Studio yêu cầu khi thiết kế)
        public FormThietLapMK() : this(string.Empty)
        {
        }

        // 🔹 Khi nhấn nút "HOÀN TẤT"
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string newPass = tb_pass.Text.Trim();
            string confirmPass = textBox1.Text.Trim();

            // Kiểm tra hợp lệ
            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_userService.IsValidPassword(newPass))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Gọi UserService để cập nhật mật khẩu
            bool result = _userService.ResetPassword(_username, newPass);

            if (result)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.Show();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật mật khẩu. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FormXacThucOTP : Form
    {
        private readonly string _username;
        private readonly UserService _userService;

        // ✅ Constructor mới — nhận username từ form Quên mật khẩu
        public FormXacThucOTP(string username)
        {
            InitializeComponent();
            _username = username;
            _userService = new UserService();
        }

        // 🔹 Khi nhấn nút "TIẾP TỤC"
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            // Ghép 6 ô nhập thành một chuỗi OTP
            string otp = string.Concat(
                tb_s1.Text.Trim(),
                tb_s2.Text.Trim(),
                tb_s3.Text.Trim(),
                tb_s4.Text.Trim(),
                tb_s5.Text.Trim(),
                tb_s6.Text.Trim()
            );

            if (otp.Length != 6 || !otp.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đủ 6 chữ số OTP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Kiểm tra OTP
            bool isValid = _userService.VerifyOtp(_username, otp);

            if (isValid)
            {
                MessageBox.Show("Xác thực OTP thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormThietLapMK formThietLapMK = new FormThietLapMK(_username);
                formThietLapMK.Show();
                this.Close();
            }
            else
            {
                // Nếu sai, UserService sẽ tự hiện thông báo hoặc có thể thêm ở đây:
                MessageBox.Show("Mã OTP không đúng hoặc đã hết hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Khi nhấn nút "GỬI LẠI MÃ"
        private void button1_Click(object sender, EventArgs e)
        {
            string newOtp = _userService.GenerateOtp(_username);
            MessageBox.Show($"Mã OTP mới của bạn là: {newOtp}\n(Chỉ hiển thị để test, sau này có thể gửi qua Email/SMS)",
                            "OTP mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
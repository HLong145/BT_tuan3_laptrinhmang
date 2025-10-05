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
    public partial class FormXacNhanDangNhapThanhCong : Form
    {
        private FormDangNhap _formDangNhap;

        // Constructor có tham số
        public FormXacNhanDangNhapThanhCong()
        {
            InitializeComponent();
            _formDangNhap = new FormDangNhap();
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                 "Xác nhận",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _formDangNhap.ClearPassword();

                // 🔹 Hiện lại form đăng nhập
                _formDangNhap.Show();

                // 🔹 Đóng form hiện tại
                this.Close();
            }
        }
    }
}
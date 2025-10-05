using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace FormDNDK
{
    public partial class FormXacNhanDangNhapThanhCong : Form
    {
        private FormDangNhap _formDangNhap;

        // Constructor nhận form đăng nhập từ bên ngoài
        public FormXacNhanDangNhapThanhCong(FormDangNhap formDangNhap)
        {
            InitializeComponent();
            _formDangNhap = formDangNhap;
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
                _formDangNhap.Show();
                this.Close();
            }
        }
    }
}
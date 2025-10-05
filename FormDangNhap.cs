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

        }

        private void btn_forgotpass_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.Show();
        }
    }
}

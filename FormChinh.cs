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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void btn_formdangnhap_Click(object sender, EventArgs e)
        {
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
        }

        private void btn_formdangky_Click(object sender, EventArgs e)
        {
            FormDangKy fDK = new FormDangKy();
            fDK.Show();
        }
    }
}

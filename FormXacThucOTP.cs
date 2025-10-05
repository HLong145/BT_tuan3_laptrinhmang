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
        public FormXacThucOTP()
        {
            InitializeComponent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            FormThietLapMK formThietLapMK = new FormThietLapMK();
            formThietLapMK.Show();
        }
    }
}

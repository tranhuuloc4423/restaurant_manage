using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_qlnhahang
{
    public partial class BillDetails : Form
    {
        public BillDetails()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BillDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}

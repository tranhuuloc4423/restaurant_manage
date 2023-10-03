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
    public partial class ChangeInfo : Form
    {
        public ChangeInfo()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

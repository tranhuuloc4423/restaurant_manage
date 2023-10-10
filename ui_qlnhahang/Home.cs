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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private string tk;
        public Home(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn rời nhà hàng", "NHÀ HÀNG FOODIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangeInfo form = new ChangeInfo(tk);
            form.ShowDialog();
        }
    }
}

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
        private string mk;

        public Home(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CustomMessBox mb = new CustomMessBox("Bạn có muốn rời nhà hàng FOODIE!");
            mb.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangeInfo form = new ChangeInfo(tk, mk);
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Transparent;
            btnChangePass.BackColor = Color.Transparent;
            btnExit.BackColor = Color.Transparent;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoMess f = new InfoMess();
            f.ShowDialog();
        }
    }
}

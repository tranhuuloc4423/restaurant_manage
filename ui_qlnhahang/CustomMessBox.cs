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
    public partial class CustomMessBox : BorderForm
    {
        string title;
        public CustomMessBox(string title)
        {
            InitializeComponent();
            CenterToScreen();
            this.title = title;
        }

        private void CustomMessBox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;
            //handleTitleBounds();
            //handleIconBounds();
            //handleExitBounds();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

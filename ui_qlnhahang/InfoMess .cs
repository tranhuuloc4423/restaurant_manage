using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;

namespace ui_qlnhahang
{
    public partial class InfoMess : BorderForm
    {
        public InfoMess()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

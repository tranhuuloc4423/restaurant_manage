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

        void handleTitleBounds()
        {
            lblTitle.Anchor = AnchorStyles.None;
            int labelWidth = lblTitle.Width;
            int labelHeight = lblTitle.Height;

            int labelX = 100;
            int labelY = (this.Height - labelHeight) / 2;

            lblTitle.SetBounds(labelX, labelY, labelWidth, labelHeight);
        }

        void handleIconBounds()
        {
            pbIcon.Anchor = AnchorStyles.None;
            int iconWidth = pbIcon.Width;
            int iconHeight = pbIcon.Height;

            int iconX = 20;
            int iconY = (this.Height - iconHeight) / 2;

            pbIcon.SetBounds(iconX, iconY, iconWidth, iconHeight);
        }

        void handleExitBounds()
        {
            btnExit.Anchor = AnchorStyles.None;
            int iconWidth = btnExit.Width;
            int iconHeight = btnExit.Height;

            int iconX = (this.Width - 50);
            int iconY = 10;
            btnExit.SetBounds(iconX, iconY, iconWidth, iconHeight);

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

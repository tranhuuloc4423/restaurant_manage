using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ui_qlnhahang
{
    public partial class MessBox : Bunifu.Framework.UI.BunifuForm
    {
        string title;
        public MessBox(string title)
        {
            InitializeComponent();
            CenterToScreen();
            this.title = title;
        }

        private void MessBox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;
            handleTitleBounds();
            handleIconBounds();
            handleExitBounds();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

            int iconX = (this.Width - 40);
            int iconY = 20;
            btnExit.SetBounds(iconX, iconY, iconWidth, iconHeight);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

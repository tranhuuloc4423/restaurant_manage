using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_qlnhahang
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            CenterToParent();
            handleLoadingBounds();
        }
        private int rotationAngle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            rotationAngle += 5;
            logo.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            logo.Refresh();
            if (rotationAngle >= 25) { this.Close(); }
        }

        void handleLoadingBounds()
        {
            logo.Anchor = AnchorStyles.None;
            int labelWidth = logo.Width;
            int labelHeight = logo.Height;

            int labelX = (this.Height - labelWidth) / 2;
            int labelY = (this.Height - labelHeight) / 2;

            logo.SetBounds(labelX, labelY, labelWidth, labelHeight);
        }
    }
        
}

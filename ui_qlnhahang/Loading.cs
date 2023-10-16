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
        }
        private int rotationAngle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            rotationAngle += 5;
            bunifuPictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            bunifuPictureBox1.Refresh();
            if (rotationAngle >= 25) { this.Close(); }

        }
    }
        
}

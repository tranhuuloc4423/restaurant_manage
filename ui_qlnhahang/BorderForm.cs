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
    public partial class BorderForm : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 3;

            using (Pen borderPen = new Pen(Color.Black, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(borderWidth / 2, borderWidth / 2,
                    ClientSize.Width - borderWidth, ClientSize.Height - borderWidth));
            }
        }
    }
}

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
    public partial class BillDetail : Form
    {
        int BillId;
        public BillDetail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public BillDetail(int selectedBillId)
        {
            InitializeComponent();
            CenterToScreen();
            this.BillId = selectedBillId;
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

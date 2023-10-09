using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_qlnhahang
{
    public partial class BillDetails : Form
    {
        private int billId;

        private string connectionString = "Data Source=.;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public BillDetails(int billID)
        {
            InitializeComponent();
            CenterToScreen();
            this.billId = billID;
        }
        private void BillDetails_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
<<<<<<< HEAD

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> c6cfb76147fb3d070a2878e3a1eed011f4ed7a3a
    }
}

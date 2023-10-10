using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class AccountManage : Form
    {
        public AccountManage()
        {
            InitializeComponent();
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            string query = "Select * from [Account]";
            GetAllData(query, gvAccount);
        }
    }
}

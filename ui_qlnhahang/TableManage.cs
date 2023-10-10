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
    public partial class TableManage : Form
    {
        public TableManage()
        {
            InitializeComponent();
        }

        private void TableManage_Load(object sender, EventArgs e)
        {
            string query = "select * from [Table]";
            GetAllData(query, gvTable);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

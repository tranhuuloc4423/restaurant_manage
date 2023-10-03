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
    public partial class TableManage : Form
    {
        public TableManage()
        {
            InitializeComponent();
        }

        private void TableManage_Load(object sender, EventArgs e)
        {

        }

        public void AddRowData(string id, string name, string state)
        {
            string[] row = { id, name, state };
            gvTable.Rows.Add(row);
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

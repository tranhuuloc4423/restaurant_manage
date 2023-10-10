using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;
using static ui_qlnhahang.FormUltility;
using static ui_qlnhahang.Order;

namespace ui_qlnhahang
{
    public partial class CateManage : Form
    {
        string query = "select * from [Category]";
        public CateManage()
        {
            InitializeComponent();
        }

            
        private void CateManage_Load(object sender, EventArgs e)
        {
            GetAllData(query, gvCate);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCate.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục món ăn");
                return;
            }
            string name = "Category_Insert";
            string query = "@Name @Type";
            DataProvider dataprovider = new DataProvider();
            dataprovider.ExecuteNonQuery(name, query, new object[] { txtCate.Text.ToString(), 1 });

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (gvCate.SelectedRows.Count > 0)
            {
                DataProvider dataprovider = new DataProvider();
                DataGridViewRow selectedRow = gvCate.SelectedRows[0];
                string name = "Category_Delete";
                string query = "@ID";
                object id = selectedRow.Cells[0].Value;
                dataprovider.ExecuteNonQuery(name, query, (object[])id);
            }
        }

        private void gvCate_SelectionChanged(object sender, EventArgs e)
        {
            if (gvCate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvCate.SelectedRows[0];
                txtCate.Text = selectedRow.Cells[1].Value.ToString();
            }
        }
    }
}

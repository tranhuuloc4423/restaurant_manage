using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class TableManage : Form
    {
        string mainquery = "select * from [Table]";
        public TableManage()
        {
            InitializeComponent();
        }

        private void TableManage_Load(object sender, EventArgs e)
        {
            string query = "select * from [Table]";
            GetAllData(query, gvTable);
            txtNameTable.Clear();
        }

        private void handleData(string name, string query, string desc, object[] parameter = null)
        {
            DataProvider dataprovider = new DataProvider();
            dataprovider.ExecuteNonQueryProvider(name, query, parameter);
            MessageBox.Show(desc);
            GetAllData(mainquery, gvTable);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameTable.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục món ăn");
                return;
            }
            string name = "Table_Insert";
            string query = "@Name @Status";
            string desc = "Thêm bàn thành công!";
            handleData(name, query, desc, new object[] { txtNameTable.Text, 0 });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvTable.SelectedRows[0];
                if (string.IsNullOrEmpty(txtNameTable.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên bàn!");
                    return;
                }
                else
                {
                    object id = selectedRow.Cells[0].Value;
                    string name = "Table_Update";
                    string query = "@ID @Name @Status";
                    string desc = "Cập nhật bàn thành công!";
                    handleData(name, query, desc, new object[] { id, txtNameTable.Text, 0 });
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvTable.SelectedRows[0];
                string name = "Table_Delete";
                string query = "@ID";
                string desc = "Xoá bàn thành công!";
                object id = selectedRow.Cells[0].Value;
                handleData(name, query, desc, new object[] { id });
            }
        }

        private void gvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvTable.SelectedRows[0];
                txtNameTable.Text = selectedRow.Cells[1].Value.ToString();
            }
        }
    }
}

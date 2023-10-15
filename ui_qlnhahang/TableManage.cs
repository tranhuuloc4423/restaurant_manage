using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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
        BunifuTextBox[] myTextBoxes;

        public TableManage()
        {
            InitializeComponent();
        }

        private void TableManage_Load(object sender, EventArgs e)
        {
            string query = "select * from [Table]";
            GetAllData(query, gvTable);
            txtNameTable.Clear();
            myTextBoxes = new BunifuTextBox[] { txtNameTable };
            handleResetTextbox(gvTable, txtNameTable, myTextBoxes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameTable.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên bàn!");
                mb.ShowDialog();
                return;
            }
            string name = "Table_Insert";
            string procedureParams = "@Name @Status";
            string desc = "Thêm bàn thành công!";
            handleProcedure(mainquery, name, procedureParams, gvTable, desc, new object[] { txtNameTable.Text, 0 });
            handleResetTextbox(gvTable, txtNameTable, myTextBoxes);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvTable.SelectedRows[0];
                if (string.IsNullOrEmpty(txtNameTable.Text))
                {
                    MessBox mb = new MessBox("Vui lòng nhập tên bàn!");
                    mb.ShowDialog();
                    return;
                }
                object id = selectedRow.Cells[0].Value;
                string name = "Table_Update";
                string procedureParams = "@ID @Name @Status";
                string desc = "Cập nhật bàn thành công!";
                handleProcedure(mainquery, name, procedureParams, gvTable, desc, new object[] { id, txtNameTable.Text, 0 });
                handleResetTextbox(gvTable, txtNameTable, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Vui lòng chọn bàn để sửa!");
                mb.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvTable.SelectedRows[0];
                string name = "Table_Delete";
                string procedureParams = "@ID";
                string desc = "Xoá bàn thành công!";
                object id = selectedRow.Cells[0].Value;
                handleProcedure(mainquery, name, procedureParams,gvTable, desc, new object[] { id });
                handleResetTextbox(gvTable, txtNameTable, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Vui lòng chọn bàn để xoá!");
                mb.ShowDialog();
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

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            string columnName = "Name";
            handleFilter(gvTable, txtSearch, mainquery, columnName);
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                handleResetTextbox(gvTable, txtSearch, myTextBoxes);
            }
        }
    }
}

using Bunifu.UI.WinForms;
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
using System.Xml.Linq;
using ui_qlnhahang.DAo;
using static ui_qlnhahang.FormUltility;
using static ui_qlnhahang.Order;

namespace ui_qlnhahang
{
    public partial class CateManage : Form
    {
        string mainquery = "select * from [Category]";
        string foodCateIDQuery = "select FoodCategoryID from [Food]";
        DataTable foodCateList;
        BunifuTextBox[] myTextBoxes;
        public CateManage()
        {
            InitializeComponent();
        }

            
        private void CateManage_Load(object sender, EventArgs e)
        {
            GetAllData(mainquery, gvCate);
            foodCateList = GetAllDataNew(foodCateIDQuery);
            myTextBoxes = new BunifuTextBox[] { txtCate };
            handleResetTextbox(gvCate, txtCate, myTextBoxes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cateName = txtCate.Text.Trim();
            if (string.IsNullOrEmpty(cateName))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên danh mục món ăn!");
                mb.ShowDialog();
                txtCate.Clear();
                return;
            }

            foreach (DataRow item in GetAllData(mainquery, gvCate).Rows)
            {
                if (item["Name"].ToString().Equals(cateName))
                {
                    MessBox mb = new MessBox("Tên danh mục đã có trong cơ sở dữ liệu!");
                    mb.ShowDialog();
                    handleResetTextbox(gvCate, txtCate, myTextBoxes);
                    return;
                }
            }
            string name = "Category_Insert";
            string procedureParams = "@Name @Type";
            string desc = "Thêm danh mục món ăn thành công!";
            handleProcedure(mainquery, name, procedureParams,gvCate, desc, new object[] { cateName, 1 });
            handleResetTextbox(gvCate, txtCate, myTextBoxes);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvCate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvCate.SelectedRows[0];
                string cateName = txtCate.Text.Trim();
                if (string.IsNullOrEmpty(cateName))
                {
                    MessBox mb = new MessBox("Vui lòng nhập tên danh mục món ăn!");
                    mb.ShowDialog();
                    txtCate.Clear();
                    return;
                }

                object id = selectedRow.Cells[0].Value;
                string name = "Category_Update";
                string procedureParams = "@ID @Name @Type";
                string desc = "Cập nhật danh mục món ăn thành công!";
                handleProcedure(mainquery, name, procedureParams, gvCate, desc, new object[] { id, cateName, 1 });
                handleResetTextbox(gvCate, txtCate, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Vui lòng chọn tên danh mục món ăn muốn sửa!");
                mb.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvCate.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvCate.SelectedRows[0];
                string name = "Category_Delete";
                string procedureParams = "@ID";
                string desc = "Xoá danh mục món ăn thành công!";
                object id = selectedRow.Cells[0].Value;

                foreach (DataRow item in foodCateList.Rows)
                {
                    if (item["FoodCategoryID"].ToString().Equals(id))
                    {
                        MessBox mb = new MessBox("Hiện đang có món ăn sử dụng danh mục món ăn này!");
                        mb.ShowDialog();
                        return;
                    } else
                    {
                        handleProcedure(mainquery, name, procedureParams, gvCate, desc, new object[] { id });
                    }
                }

                
                handleResetTextbox(gvCate, txtCate, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Vui lòng chọn tên danh mục món ăn muốn xoá!");
                mb.ShowDialog();
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

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            string columnName = "Name";
            handleFilter(gvCate, txtSearch, mainquery, columnName);
            if(String.IsNullOrEmpty(txtSearch.Text))
            {
                handleResetTextbox(gvCate, txtSearch, myTextBoxes);
            }
        }
    }
}

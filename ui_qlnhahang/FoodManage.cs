using Bunifu.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ui_qlnhahang.DAo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class FoodManage : Form
    {
        public string mainquery = "SELECT F.ID, F.Name AS Name, C.Name AS CategoryName, F.Price\r\nFROM Food F\r\nJOIN Category C ON F.FoodCategoryID = C.ID";
        public string queryNameOfFood = "select name from [Category]";
        public string queryCategory = "select *  from [Category]";
        public DataTable categoryList;
        BunifuTextBox[] myTextBoxes;
        public FoodManage()
        {
            InitializeComponent();
        }

        private void bunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FoodManage_Load(object sender, EventArgs e)
        {
            categoryList = GetTableData(queryCategory);
            GetAllData(mainquery, gvFood);
            GetAllData(queryNameOfFood, dpdCate);
            dpdCate.Text = dpdCate.Items[0].ToString();
            myTextBoxes = new BunifuTextBox[] { txtFoodName, txtPrice };
            handleResetTextbox(gvFood,txtFoodName, myTextBoxes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFoodName.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên món ăn!");
                mb.ShowDialog();
                return;
            }

            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập giá món ăn!");
                mb.ShowDialog();

                return;
            }
            string name = txtFoodName.Text;
            string foodCateText = dpdCate.Text;
            int foodPrice = Convert.ToInt32(txtPrice.Text);
            int foodCateID = 0;

            foreach (DataRow row in categoryList.Rows)
            {
                if (row["Name"].ToString() == foodCateText)
                {
                    foodCateID = Convert.ToInt32(row["ID"]);
                    break;
                }
            }
            string nameProcedure = "[InsertFood]";
            string procedureParams = "@Name @FoodCategoryID @Price";
            string desc = "Thêm món ăn thành công";
            handleProcedure(mainquery, nameProcedure, procedureParams, gvFood, desc, new object[] { name, foodCateID, foodPrice });
            handleResetTextbox(gvFood, txtFoodName, myTextBoxes);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvFood.SelectedRows[0];

                if (String.IsNullOrEmpty(txtFoodName.Text))
                {
                    MessBox mb = new MessBox("Vui lòng nhập tên món ăn!");
                    mb.ShowDialog();
                    return;
                }

                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    MessBox mb = new MessBox("Vui lòng nhập giá món ăn!");
                    mb.ShowDialog();
                }

                object id = selectedRow.Cells[0].Value;
                string name = txtFoodName.Text;
                string foodCateText = dpdCate.Text;
                int foodPrice = Convert.ToInt32(txtPrice.Text);
                int foodCateID = 0;

                foreach (DataRow row in categoryList.Rows)
                {
                    if (row["Name"].ToString() == foodCateText)
                    {
                        foodCateID = Convert.ToInt32(row["ID"]);
                        break;
                    }
                }
                string nameProcedure = "[UpdateFood]";
                string procedureParams = "@ID @Name @FoodCategoryID @Price";
                string desc = "Cập nhật món ăn thành công!";
                handleProcedure(mainquery, nameProcedure, procedureParams,gvFood, desc, new object[] { id, name, foodCateID, foodPrice });
                handleResetTextbox(gvFood, txtFoodName, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Vui lòng chọn món ăn muốn sửa!");
                mb.ShowDialog();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvFood.SelectedRows[0];
                object id = selectedRow.Cells[0].Value;

                string nameProcedure = "[DeleteFood]";
                string procedureParams = "@FoodID";
                string desc = "Xoá món ăn thành công!";
                handleProcedure(mainquery ,nameProcedure, procedureParams, gvFood, desc, new object[] { id });
                handleResetTextbox(gvFood, txtFoodName, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Chọn món ăn để xoá!");
                mb.ShowDialog();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (gvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvFood.SelectedRows[0];
                txtFoodName.Text = selectedRow.Cells[1].Value.ToString();
                dpdCate.Text = selectedRow.Cells[2].Value.ToString();
                txtPrice.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            string columnName = "Name";
            handleFilter(gvFood, txtSearch, mainquery, columnName);
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                handleResetTextbox(gvFood, txtSearch, myTextBoxes);
            }
        }
    }
}

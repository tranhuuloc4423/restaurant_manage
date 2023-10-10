using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class FoodManage : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public string query = "select * from [Food]";
        public string queryNameOfFood = "select name from [Category]";
        public string queryCategory = "select *  from [Category]";
        public DataTable categoryList;
        public DataTable foodList;
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

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodManage_Load(object sender, EventArgs e)
        {
            categoryList = GetTableData(queryCategory);
            GetAllData(query, gvFood);
            GetAllData(queryNameOfFood, dpdCate);
            dpdCate.Text = dpdCate.Items[0].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            string foodCateText = dpdCate.Text;
            string foodPrice = txtPrice.Text;
            int foodCateID = 0;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn");
                return;
            }

            if (String.IsNullOrEmpty(foodCateText))
            {
                MessageBox.Show("Vui lòng chọn danh mục món ăn");
                return;
            }

            if (String.IsNullOrEmpty(foodPrice))
            {
                MessageBox.Show("Vui lòng nhập giá món ăn");
                return;
            }

            foreach (DataRow row in categoryList.Rows)
            {
                if (row["Name"].ToString() == foodCateText)
                {
                    foodCateID = Convert.ToInt32(row["ID"]);
                    break;
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("[InsertFood]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@FoodCategoryID", foodCateID);
                command.Parameters.AddWithValue("@Price", Convert.ToInt32(foodPrice));
                command.ExecuteNonQuery();
                GetAllData(query, gvFood);
            }

            txtFoodName.Clear();
            txtPrice.Clear();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvFood.SelectedRows[0];

                // Lấy giá trị của cột cụ thể từ hàng được chọn
                object id = selectedRow.Cells[0].Value;
                string name = txtFoodName.Text;
                string foodCateText = dpdCate.Text;
                string foodPrice = txtPrice.Text;
                int foodCateID = 0;
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn");
                    return;
                }

                if (String.IsNullOrEmpty(foodCateText))
                {
                    MessageBox.Show("Vui lòng chọn danh mục món ăn");
                    return;
                }

                if (String.IsNullOrEmpty(foodPrice))
                {
                    MessageBox.Show("Vui lòng nhập giá món ăn");
                    return;
                }

                foreach (DataRow row in categoryList.Rows)
                {
                    if (row["Name"].ToString() == foodCateText)
                    {
                        foodCateID = Convert.ToInt32(row["ID"]);
                        break;
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("[UpdateFood]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@FoodCategoryID", foodCateID);
                    command.Parameters.AddWithValue("@Price", Convert.ToInt32(foodPrice));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật món ăn thành công!");
                    GetAllData(query, gvFood);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvFood.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvFood.SelectedRows[0];
                object id = selectedRow.Cells[0].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("[DeleteFood]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FoodID", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xoá món ăn thành công!");
                    GetAllData(query, gvFood);
                }
            } else
            {
                MessageBox.Show("Chọn món ăn để xoá");
            }
        }

        private void dpdCate_SelectedValueChanged(object sender, EventArgs e)
        {

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
                txtPrice.Text = selectedRow.Cells[3].Value.ToString();
                string foodCate;
                foreach (DataRow row in categoryList.Rows)
                {
                    if (row["ID"].ToString().Equals(selectedRow.Cells[2].Value.ToString()))
                    {
                        foodCate = row["Name"].ToString();
                        dpdCate.Text = foodCate;
                        break;
                    }
                }
            }
        }
    }
}

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
    public partial class FoodManage : Form
    {
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

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodManage_Load(object sender, EventArgs e)
        {
            // xử lý đổ dữ liệu vào gridview ==> gvFood
            AddRowData("1", "gà rán", "100000", "Món chính");
            AddRowData("2", "gỏi cuốn", "80000", "Món khai vị");
        }

        public void AddRowData(string id, string name, string price, string cate)
        {
            string[] row = { id, name, price, cate};
            gvFood.Rows.Add(row);
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

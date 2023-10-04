using System;
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

namespace ui_qlnhahang
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        void loadFoodlist()
        {


            string query = "Select * from [Food]";

            DataProvider provider = new DataProvider();

            FoodDataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        

        private void Order_Load(object sender, EventArgs e)
        {
            loadFoodlist();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FoodDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
using static System.Net.Mime.MediaTypeNames;

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
            string query = "Select Name from [Food]";

            DataProvider provider = new DataProvider();


            AddNamesToDropdown(provider.ExecuteQuery(query));
        }

        public class Food
        {
            public int FoodId { get; set; }
            public string FoodName { get; set; }
            public int FoodCategoryId { get; set; }
            public decimal Price { get; set; }
        }

        public List<Food> GetAllFoodData()
        {
            List<Food> foodList = new List<Food>();
            string query = "SELECT ID, Name, FoodCategoryID, Price FROM Food";

            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                int foodId = (int)row["ID"];
                string foodName = (string)row["Name"];
                int foodCategoryId = (int)row["FoodCategoryID"];
                decimal foodPrice = (decimal)row["Price"];

                Food food = new Food
                {
                    FoodId = foodId,
                    FoodName = foodName,
                    FoodCategoryId = foodCategoryId,
                    Price = foodPrice
                };
                foodList.Add(food);
            }

            return foodList;
        }



        public void AddNamesToDropdown(DataTable data)
        {
            FoodlistDropdown1.Items.Clear(); // Clear existing items

            foreach (DataRow row in data.Rows)
            {
                string name = row["Name"].ToString();
                FoodlistDropdown1.Items.Add(name);
            }
        }



        private void Order_Load(object sender, EventArgs e)
        {
            loadFoodlist();

            int TotalTable = 22;
            

        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void FoodDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<OrderListed> tableList = new List<OrderListed>();
        private int currentRowIndex = 0;
        int tableindex=0;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            tableindex = 1;
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            tableindex = 2;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            tableindex = 3;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            tableindex = 4;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            tableindex = 5;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            tableindex = 6;
        }
         
        
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            int rowIndex = 0; // Index of the desired row (e.g., 0 for the first row)
            int columnIndex = 0; // Index of the desired column (e.g., 2 for the third column)
            List<Food> foodData = GetAllFoodData();
            string selectedFood = FoodlistDropdown1.SelectedItem?.ToString();
            FoodDataGridView1.Rows[rowIndex].Cells[columnIndex].Value = selectedFood;
            //tableList[tableindex=1].AddItem();
        }
    }

        
    public class OrderItem
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class OrderListed
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public OrderListed()
        {
            OrderItems = new List<OrderItem>();
        }

        public void AddItem(int foodId, string foodName, int quantity, decimal price)
        {
            OrderItem item = new OrderItem
            {
                FoodId = foodId,
                FoodName = foodName,
                Quantity = quantity,
                Price = price
            };

            OrderItems.Add(item);
        }

        public void RemoveItem(int foodId)
        {
            OrderItem item = OrderItems.Find(i => i.FoodId == foodId);
            if (item != null)
            {
                OrderItems.Remove(item);
            }
        }

        public void UpdateQuantity(int foodId, int newQuantity)
        {
            OrderItem item = OrderItems.Find(i => i.FoodId == foodId);
            if (item != null)
            {
                item.Quantity = newQuantity;
            }
        }

        public int GetTotalQuantity()
        {
            int totalQuantity = 0;
            foreach (OrderItem item in OrderItems)
            {
                totalQuantity += item.Quantity;
            }

            return totalQuantity;
        }
    }


    /*public class Table
    {
        public int tableIndex { get; set; }
        int NumberOfFoodRow;
        public void createFoodList()
        {
            OrderListed orderListed = new OrderListed();
        }

        

    }*/
}

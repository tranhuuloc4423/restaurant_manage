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

        void addFoodDropdown() 
        {
            string query = "Select Name from [Food]";

            DataProvider provider = new DataProvider();

           
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

    public class OrderItem
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
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

        public void AddItem(int foodId, string foodName, int quantity)
        {
            OrderItem item = new OrderItem
            {
                FoodId = foodId,
                FoodName = foodName,
                Quantity = quantity
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
}

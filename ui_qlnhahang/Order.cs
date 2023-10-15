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
using static System.Net.Mime.MediaTypeNames;
using static ui_qlnhahang.Order;

namespace ui_qlnhahang
{
    public partial class Order : Form
    {
        private string tk;
        public int totalTable;
        //public Order()
        //{
        //    InitializeComponent();
        //    GetAllFoodData();

        //    //orderManager.CreateOrder(0, DateTime.Now);
        //    //orderManager.CreateOrder(1, DateTime.Now);
        //    //orderManager.CreateOrder(2, DateTime.Now);
        //    //orderManager.CreateOrder(3, DateTime.Now);
        //    //orderManager.CreateOrder(4, DateTime.Now);
        //    //orderManager.CreateOrder(5, DateTime.Now);
        //    //orderManager.CreateOrder(6, DateTime.Now);
        //    //orderManager.CreateOrder(7, DateTime.Now);
        //    //orderManager.CreateOrder(8, DateTime.Now);
        //    //orderManager.CreateOrder(9, DateTime.Now);
        //    //orderManager.CreateOrder(10, DateTime.Now);
        //    //orderManager.CreateOrder(11, DateTime.Now);
        //    //orderManager.CreateOrder(12, DateTime.Now);
        //    //orderManager.CreateOrder(13, DateTime.Now);
        //    //orderManager.CreateOrder(14, DateTime.Now);
        //    //orderManager.CreateOrder(15, DateTime.Now);
        //    //orderManager.CreateOrder(16, DateTime.Now);
        //    //orderManager.CreateOrder(17, DateTime.Now);
        //    //orderManager.CreateOrder(18, DateTime.Now);
        //    //orderManager.CreateOrder(19, DateTime.Now);
        //    for (int i = 0; i < 100; i++)
        //    {
        //        orderManager.CreateOrder(i, DateTime.Now);
        //    }

        //}

        public Order(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            GetAllFoodData();
            LoadTables();
            for (int i = 0; i <= totalTable; i++)
            {
                orderManager.CreateOrder(i, DateTime.Now);
            }
        }
        OrderManager orderManager = new OrderManager();


        public class OrderItem
        {
            public int FoodId { get; set; }
            public string FoodName { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
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

            public void AddItem(int foodId, string foodName, int quantity, int price)
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

        public class OrderManager
        {
            public List<OrderListed> orders;

            public OrderManager()
            {
                orders = new List<OrderListed>();
            }

            public void loadorderToGridView(int index, DataGridView dataGridView)
            {
                OrderListed order = orders[index];
                foreach (OrderItem item in order.OrderItems)
                {
                    string foodName = item.FoodName;
                    int price = item.Price;
                    int quantity = item.Quantity;
                    int totalPrice = price * quantity;

                    dataGridView.Rows.Add(foodName, price, quantity, totalPrice);
                }
            }
            int invoiceID = 0;

            public void checkoutToBills(int index,string staffname)
            {
                DataProvider provider = new DataProvider();
                OrderListed order = orders[index];
                int totalAmount = 0;

                foreach (OrderItem item in order.OrderItems)
                {
                    int quantity = item.Quantity;
                    int amount = item.Price * quantity;
                    totalAmount += amount;
                }
                if (totalAmount !=0) {
                    string name = "Hóa đơn " + (invoiceID + 1);
                    int tableID = index + 1;
                    float status = 1;

                    // đổi thành định dạng chuẩn ISO "yyyy-MM-dd"
                    string checkoutDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string account = staffname.ToLower();

                    string query = "INSERT INTO [dbo].[Bills] ([Name], [TableID], [Amount], [Status], [CheckoutDate], [Account]) " +
                                       "VALUES (@Name, @TableID, @Amount, @Status, @CheckoutDate, @Account)";

                    using (SqlConnection connection = new SqlConnection(provider.getconnectionSTR()))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@TableID", tableID);
                        command.Parameters.AddWithValue("@Amount", totalAmount);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@CheckoutDate", checkoutDate);
                        command.Parameters.AddWithValue("@Account", account);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                

            }


            public void checkoutToBillDetails(int index)
            {

                OrderListed order = orders[index];

                int totalAmount = 0;

                DataProvider provider = new DataProvider();
                string query1 = "SELECT MAX(ID) FROM Bills";

                using (SqlConnection connection = new SqlConnection(provider.getconnectionSTR()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            invoiceID = Convert.ToInt32(result);
                        }
                    }

                    connection.Close();
                }

                foreach (OrderItem item in order.OrderItems)
                {
                    int name = invoiceID;
                    int tableID = index + 1;
                    int quantity = item.Quantity;
                    
                    
                    

                    string query = "INSERT INTO [dbo].[BillDetails] ([InvoiceID],  [FoodID], [Quantity]) " +
                                   "VALUES (@Name, @TableID, @Amount)";

                    using (SqlConnection connection = new SqlConnection(provider.getconnectionSTR()))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", invoiceID);
                        command.Parameters.AddWithValue("@TableID", tableID);
                        command.Parameters.AddWithValue("@Amount", quantity);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }



                order.OrderItems.Clear();

            }

            public void CreateOrder(int orderId, DateTime orderDate)
            {
                OrderListed order = new OrderListed
                {
                    OrderId = orderId,
                    OrderDate = orderDate
                };

                orders.Add(order);
            }

            public void AddItemToOrder(int orderId, int foodId, string foodName, int quantity, int price)
            {
                OrderListed order = orders.Find(o => o.OrderId == orderId);
                if (order != null)
                {
                    OrderItem existingItem = order.OrderItems.FirstOrDefault(item => item.FoodId == foodId);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += quantity;
                    }
                    else
                    {
                        order.AddItem(foodId, foodName, quantity, price);
                    }
                }
            }

            public void RemoveItemFromOrder(int orderId, int foodId)
            {
                OrderListed order = orders.Find(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.RemoveItem(foodId);
                }
            }

            public void UpdateQuantityInOrder(int orderId, int foodId, int newQuantity)
            {
                OrderListed order = orders.Find(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.UpdateQuantity(foodId, newQuantity);
                }
            }

            public int GetTotalQuantityInOrder(int orderId)
            {
                OrderListed order = orders.Find(o => o.OrderId == orderId);
                if (order != null)
                {
                    return order.GetTotalQuantity();
                }

                return 0;
            }
        }

        List<string> loadFoodlist(int foodCategoryId)
        {
            /*string query = "Select FoodCategoryID, Name from [Food]";

            DataProvider provider = new DataProvider();


            AddNamesToDropdown(provider.ExecuteQuery(query));*/

            string query = $"SELECT Name FROM Food WHERE FoodCategoryID = {foodCategoryId}";

            DataProvider provider = new DataProvider();
            return AddNamesToDropdown(provider.ExecuteQuery(query));
        }

        void loadCatlist()
        {
            string query = "Select ID, Name from [Category]";

            DataProvider provider = new DataProvider();


            AddCatsToDropdown(provider.ExecuteQuery(query));
        }

        int  getInvoiceID()
        {
            int invoiceID = 0;
            string query = "SELECT InvoiceID FROM BillDetails WHERE ID = (SELECT MAX(ID) FROM BillDetails)";

            DataProvider provider = new DataProvider();
            
            DataTable dataTable = provider.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                invoiceID = Convert.ToInt32(lastRow["InvoiceID"]);
            }

            return invoiceID;

        }


        public class Food
        {
            public int FoodId { get; set; }
            public string FoodName { get; set; }
            public int FoodCategoryId { get; set; }
            public int Price { get; set; }
        }

        /*public List<Food> GetAllFoodData()
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
                int foodPrice = (int)row["Price"];

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
        }*/
        private List<Food> foodList;

        void GetAllFoodData()
        {

            string query = "SELECT [ID], [Name], [FoodCategoryID], [Price] FROM [dbo].[Food]";

            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);

            foodList = new List<Food>();
            foreach (DataRow row in dataTable.Rows)
            {
                int foodId = Convert.ToInt32(row["ID"]);
                string foodName = row["Name"].ToString();
                int foodCategoryId = Convert.ToInt32(row["FoodCategoryID"]);
                int price = Convert.ToInt32(row["Price"]);

                Food food = new Food
                {
                    FoodId = foodId,
                    FoodName = foodName,
                    FoodCategoryId = foodCategoryId,
                    Price = price
                };

                foodList.Add(food);
            }
        }


        int tableindex = 1;

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            //string selectedFoodName = FoodlistDropdown1.SelectedItem.ToString();



            if (FoodDataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = FoodDataGridView1.SelectedRows[0].Index;
                string selectedFoodName = FoodDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MessBox mess = new MessBox(selectedFoodName);
                mess.ShowDialog();
                Food selectedFood = foodList.Find(food => food.FoodName == selectedFoodName);
                orderManager.RemoveItemFromOrder(tableindex, selectedFood.FoodId);
                FoodDataGridView1.Rows.Clear();
                orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
                getTotalBill();
            } else
            {
                MessBox mess = new MessBox("Vui lòng chọn món để xoá!");
                mess.ShowDialog();
            }
        }


        // button thêm món t đổi tên 
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string selectedFoodName = FoodlistDropdown1.SelectedItem.ToString();
            int quantity = (int)numericUpDown1.Value;

            Food selectedFood = foodList.Find(food => food.FoodName.Equals(selectedFoodName));

            if (selectedFood != null)
            {
                //int totalPrice = selectedFood.Price * quantity;
                int totalPrice = selectedFood.Price;

                orderManager.AddItemToOrder(tableindex, selectedFood.FoodId, selectedFood.FoodName, quantity, totalPrice);

                //FoodDataGridView1.Rows.Add(selectedFood.FoodName, selectedFood.Price, quantity, totalPrice);
                FoodDataGridView1.Rows.Clear();

                orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
                getTotalBill();

                // reset sau khi add món ăn
                numericUpDown1.Value = 1;
            }
        }


        public int getTotalBill() {
            int totalValue = 0;

            foreach (DataGridViewRow row in FoodDataGridView1.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null && int.TryParse(row.Cells["TotalPrice"].Value.ToString(), out int totalPrice))
                {
                    totalValue += totalPrice;
                }
            }
            bunifuLabel7.Text = totalValue.ToString("N0") + " VND";
            return totalValue;
        }


        public List<string> AddNamesToDropdown(DataTable data)
        {
            FoodlistDropdown1.Items.Clear(); 
            List<string> foodNames = new List<string>();

            foreach (DataRow row in data.Rows)
            {
                string name = row["Name"].ToString();
                FoodlistDropdown1.Items.Add(name);
                foodNames.Add(name);
            }

            return foodNames;
        }

        public void AddCatsToDropdown(DataTable data)
        {
            /*TypeDropdown.Items.Clear(); // Clear existing items

            foreach (DataRow row in data.Rows)
            {
                string name = row["Name"].ToString();
                TypeDropdown.Items.Add(name);
            }*/

            TypeDropdown.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                string name = row["Name"].ToString();
                TypeDropdown.Items.Add(name);
            }

            // Select the default category
            TypeDropdown.SelectedIndex = 0;
        }



        private void Order_Load(object sender, EventArgs e)
        {
            //loadFoodlist();
            loadCatlist();
            //LoadTables();

        }
        public void LoadTables()
        {
            panelBtns.Controls.Clear();

            // Tạo kết nối đến cơ sở dữ liệu và truy vấn danh sách bàn ăn
            DataProvider provider = new DataProvider();
            DataTable tableData = provider.ExecuteQuery("select * from [Table]");
            // Sử dụng FlowLayoutPanel để chứa các nút bàn ăn
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.Dock = DockStyle.Fill;
            // Duyệt qua từng dòng dữ liệu trong bảng
            foreach (DataRow row in tableData.Rows)
            {
                totalTable++;
                // Tạo một nút đại diện cho mỗi bàn ăn
                Button tableButton = new Button();
                tableButton.Text = row["Name"].ToString();
                tableButton.Name = "btnTable_" + row["ID"].ToString();
                tableButton.Width = 150;
                tableButton.Height = 75;
                //tableButton.Image =
                tableButton.FlatStyle = FlatStyle.Flat;

                // Xử lý sự kiện khi nút được nhấp
                tableButton.Click += TableButton_Click;

                // Thêm nút vào form
                flowLayoutPanel.Controls.Add(tableButton);
            }
            panelBtns.Controls.Add(flowLayoutPanel);
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button tableButton = (Button)sender;
            int tableID = Convert.ToInt32(tableButton.Name.Split('_')[1]);
            tableindex = tableID;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
            //MessageBox.Show(tableID.ToString());
        }



        private void TypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = TypeDropdown.SelectedIndex + 1;

            List<string> foodNames = loadFoodlist(selectedCategoryId);

            if (foodNames.Count > 0)
            {
                FoodlistDropdown1.SelectedIndex = 0;
            }
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

        //public void LoadTables()
        //{
        //    panelBtns.Controls.Clear();

        //    // Tạo kết nối đến cơ sở dữ liệu và truy vấn danh sách bàn ăn
        //    DataProvider provider = new DataProvider();
        //    DataTable tableData = provider.ExecuteQuery("select * from [Table]");

        //    // Duyệt qua từng dòng dữ liệu trong bảng
        //    foreach (DataRow row in tableData.Rows)
        //    {
        //        // Tạo một nút đại diện cho mỗi bàn ăn
        //        Button tableButton = new Button();
        //        tableButton.Text = row["ID"].ToString();
        //        tableButton.Name = row["Name"].ToString();
        //        tableButton.Width = 95;
        //        tableButton.Height = 75;

        //        // Xử lý sự kiện khi nút được nhấp
        //        tableButton.Click += TableButton_Click;

        //        // Thêm nút vào form
        //        this.Controls.Add(tableButton);
        //    }
        //}

        //private void TableButton_Click(object sender, EventArgs e)
        //{
        //    Button tableButton = (Button)sender;
        //    int tableID = Convert.ToInt32(tableButton.Name);
        //    FoodDataGridView1.Rows.Clear();
        //    orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
        //    getTotalBill();
        //}

        List<OrderListed> tableList = new List<OrderListed>();
        private int currentRowIndex = 0;
        

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            tableindex = 0;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            tableindex = 1;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            tableindex = 2;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            tableindex = 3;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            tableindex = 4;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            tableindex = 5;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            tableindex = 6;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            tableindex = 7;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            tableindex = 8;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            tableindex = 9;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            tableindex = 10;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            tableindex = 11;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            tableindex = 12;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            tableindex = 13;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            tableindex = 14;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            tableindex = 15;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            tableindex = 16;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            tableindex = 17;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            tableindex = 18;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            tableindex = 19;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableindex, FoodDataGridView1);
            getTotalBill();
            // số bàn  = tableindex + 1
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            if (orderManager.orders[tableindex].OrderItems != null)
            {

                //orderManager.checkoutToBillDetails(tableindex, label1);
                orderManager.checkoutToBills(tableindex, tk);

                orderManager.checkoutToBillDetails(tableindex);

                FoodDataGridView1.Rows.Clear();
            }
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

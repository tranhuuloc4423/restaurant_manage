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
using ui_qlnhahang.Properties;
using static System.Net.Mime.MediaTypeNames;
using static ui_qlnhahang.Order;
using Image = System.Drawing.Image;
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class Order : Form
    {
        private string tk;
        public int totalTable;
        string query = "select ID from [Table]";
        DataTable listTable;
        public Order(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            //listTable = GetAllDataNew(query);
            GetAllFoodData();
            LoadTables();
            for (int i = 0; i <= 100; i++)
            {
                orderManager.CreateOrder(i, DateTime.Now);
            }
            //orderManager.CreateOrder(0, DateTime.Now);

            //foreach (DataRow item in listTable.Rows)
            //{
            //    orderManager.CreateOrder(Convert.ToInt32(item["ID"]), DateTime.Now);
            //    MessageBox.Show(item["ID"].ToString());
            //}
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
                if (totalAmount != 0) {
                    string name = "Hóa đơn " + (invoiceID + 1);
                    int tableID = index;
                    //int tableID = index + 1;
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
                else
                {
                    MessBox mb = new MessBox("Vui lòng đặt món ăn!");
                    mb.ShowDialog();
                    return;
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
                    int fooid = item.FoodId;
                    int quantity = item.Quantity;
                                     
                    string query = "INSERT INTO [dbo].[BillDetails] ([InvoiceID],  [FoodID], [Quantity]) " +
                                   "VALUES (@Name, @TableID, @Amount)";

                    using (SqlConnection connection = new SqlConnection(provider.getconnectionSTR()))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", invoiceID);
                        command.Parameters.AddWithValue("@TableID", fooid);
                        command.Parameters.AddWithValue("@Amount", quantity);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Lấy ID của hóa đơn được chọn
                if ( order.OrderItems.Count != 0) {
                    BillDetail detailForm = new BillDetail(invoiceID);
                    detailForm.ShowDialog();
                }
                order.OrderItems.Clear();

                // Tạo form Chi tiết hóa đơn và truyền ID cho nó

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
            if (FoodDataGridView1.Rows.Count == 0)
            {
                clearTable(tableindex);
            }
        }


        // button thêm món t đổi tên 
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            
            
                string buttonName = "btnTable_" + tableindex.ToString();
                Control[] buttons = this.Controls.Find(buttonName, true);

                if (buttons.Length > 0 && buttons[0] is Button)
                {
                    Button button = (Button)buttons[0];
                    button.BackgroundImage = Resources.dining_table; // Set the desired color
                }
            

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

        }

        public void LoadTables()
        {
            panelBtns.Controls.Clear();
            panelBtns.Padding = new Padding(0);

            // Tạo kết nối đến cơ sở dữ liệu và truy vấn danh sách bàn ăn
            DataProvider provider = new DataProvider();
            DataTable tableData = provider.ExecuteQuery("select * from [Table]");

            // Sử dụng FlowLayoutPanel chính để cuộn dọc
            FlowLayoutPanel mainFlowLayoutPanel = new FlowLayoutPanel();
            mainFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            mainFlowLayoutPanel.WrapContents = false;
            mainFlowLayoutPanel.AutoSize = true;
            mainFlowLayoutPanel.Anchor = AnchorStyles.None;
            mainFlowLayoutPanel.Dock = DockStyle.Fill;

            int maxButtonsPerRow = 4; // Số lượng button tối đa trong một dòng
            int buttonWidth = 100;
            int buttonHeight = 100;
            int rowWidth = maxButtonsPerRow * buttonWidth;

            FlowLayoutPanel currentFlowLayoutPanel = null; // FlowLayoutPanel hiện tại đang chứa các button

            // Duyệt qua từng dòng dữ liệu trong bảng
            foreach (DataRow row in tableData.Rows)
            {
                totalTable++;

                // Nếu currentFlowLayoutPanel chưa được tạo hoặc đã đầy dòng, tạo một dòng mới
                if (currentFlowLayoutPanel == null || currentFlowLayoutPanel.Controls.Count == maxButtonsPerRow)
                {
                    currentFlowLayoutPanel = new FlowLayoutPanel();
                    currentFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                    currentFlowLayoutPanel.WrapContents = false;
                    currentFlowLayoutPanel.AutoSize = true;

                    // Thêm FlowLayoutPanel hiện tại vào FlowLayoutPanel chính
                    mainFlowLayoutPanel.Controls.Add(currentFlowLayoutPanel);
                }

                TableLayoutPanel tableLayout = new TableLayoutPanel();
                tableLayout.ColumnCount = 1;
                tableLayout.RowCount = 2;
                tableLayout.AutoSize = true;

                Label tableLabel = new Label();
                tableLabel.Text = row["Name"].ToString();
                tableLabel.TextAlign = ContentAlignment.MiddleCenter;
                tableLabel.Font = new Font("Tahoma", 10, FontStyle.Bold);


                // Tạo một nút đại diện cho mỗi bàn ăn
                Button tableButton = new Button();
                //tableButton.Text = row["Name"].ToString();
                tableButton.Name = "btnTable_" + row["ID"].ToString();
                tableButton.Width = buttonWidth;
                tableButton.Height = buttonHeight;

                tableButton.BackgroundImage = Resources.emty_table;
                tableButton.BackgroundImageLayout = ImageLayout.Stretch;
                tableButton.FlatStyle = FlatStyle.Flat;
                tableButton.Margin = new Padding(10);

                // Xử lý sự kiện khi nút được nhấp
                tableButton.Click += TableButton_Click;

                tableLayout.Controls.Add(tableLabel, 0, 0);
                tableLayout.Controls.Add(tableButton, 0, 1);
                currentFlowLayoutPanel.Controls.Add(tableLayout);
            }

            // Thêm FlowLayoutPanel chính vào panel chứa
            panelBtns.Controls.Add(mainFlowLayoutPanel);
            panelBtns.AutoScroll = true;
            panelBtns.AutoScrollMinSize = mainFlowLayoutPanel.PreferredSize;

            mainFlowLayoutPanel.Anchor = AnchorStyles.None;
            mainFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Tính toán vị trí căn giữa
            int x = (panelBtns.Width - mainFlowLayoutPanel.Width) / 2;
            mainFlowLayoutPanel.Location = new Point(x, mainFlowLayoutPanel.Location.Y);
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button tableButton = (Button)sender;
            int tableID = Convert.ToInt32(tableButton.Name.Split('_')[1]);
            tableindex = tableID;
            FoodDataGridView1.Rows.Clear();
            orderManager.loadorderToGridView(tableID, FoodDataGridView1);
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

        List<OrderListed> tableList = new List<OrderListed>();
        private int currentRowIndex = 0;

        void clearTable(int tableindex)
        {
            string buttonName = "btnTable_" + tableindex.ToString();
            Control[] buttons = this.Controls.Find(buttonName, true);

            if (buttons.Length > 0 && buttons[0] is Button)
            {
                Button button = (Button)buttons[0];
                button.BackgroundImage = Resources.emty_table; // Set the desired color
            }
        }


       

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            clearTable(tableindex);


            //orderManager.checkoutToBillDetails(tableindex, label1);
            orderManager.checkoutToBills(tableindex, tk);
            
            
            orderManager.checkoutToBillDetails(tableindex);
            
            FoodDataGridView1.Rows.Clear();
        }
    }
}

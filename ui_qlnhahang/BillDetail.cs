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
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class BillDetail : BorderForm
    {
        // ID của hóa đơn
        int billID;

        // Constructor mặc định
        public BillDetail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        // Constructor với tham số là ID của hóa đơn được chọn
        public BillDetail(int selectedBillID)
        {
            InitializeComponent();
            CenterToScreen();
            billID = selectedBillID;
        }

        // Sự kiện khi form BillDetail được tải
        private void BillDetail_Load(object sender, EventArgs e)
        {
            // Load chi tiết hóa đơn
            LoadBillDetail();
        }

        // Phương thức để tải chi tiết hóa đơn
        private void LoadBillDetail()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
                {
                    connection.Open();

                    // Truy vấn SQL để lấy chi tiết hóa đơn và thông tin món ăn
                    string query = @"SELECT BD.InvoiceID, F.Name, BD.Quantity, F.Price
                            FROM BillDetails BD
                            INNER JOIN Food F ON BD.FoodID = F.ID
                            WHERE BD.InvoiceID = @BillID";

                    // Thực thi truy vấn
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BillID", billID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trong DataGridView
                    bunifuDataGridView1.DataSource = dataTable;

                    // Lấy tổng số tiền từ hóa đơn
                    SqlCommand command2 = new SqlCommand("Amount_GetById", connection);
                    command2.CommandType = CommandType.StoredProcedure;
                    command2.Parameters.AddWithValue("@ID", billID);
                    object result2 = command2.ExecuteScalar();

                    // Hiển thị tổng số tiền hoặc thông báo nếu không có dữ liệu
                    if (result2 != null)
                    {
                        lblTotal.Text = result2.ToString();
                    }
                    else
                    {
                        lblTotal.Text = "Không có dữ liệu";
                    }

                    // Lấy ngày thanh toán từ hóa đơn
                    SqlCommand command3 = new SqlCommand("Date_GetById", connection);
                    command3.CommandType = CommandType.StoredProcedure;
                    command3.Parameters.AddWithValue("@ID", billID);
                    object result3 = command3.ExecuteScalar();

                    // Hiển thị ngày thanh toán hoặc thông báo nếu không có dữ liệu
                    if (result3 != null)
                    {
                        DateTime dateValue;
                        if (DateTime.TryParse(result3.ToString(), out dateValue))
                        {
                            string formattedDate = dateValue.ToString("dd/MM/yyyy");

                            lblBillDate.Text = formattedDate; 
                        }
                        else
                        {
                            lblBillDate.Text = "Không thể định dạng ngày tháng";
                        }
                    }
                    else
                    {
                        lblBillDate.Text = "Không có dữ liệu";
                    }

                    // Lấy ID của hóa đơn và hiển thị hoặc thông báo nếu không có dữ liệu
                    SqlCommand command4 = new SqlCommand("GetID", connection);
                    command4.CommandType = CommandType.StoredProcedure;
                    command4.Parameters.AddWithValue("@ID", billID);
                    object result4 = command4.ExecuteScalar();
                    if (result4 != null)
                    {
                        lblBillID.Text = result4.ToString();
                    }
                    else
                    {
                        lblBillID.Text = "Không có dữ liệu";
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

            // Đặt tên các cột trong DataGridView
            foreach (DataGridViewColumn column in bunifuDataGridView1.Columns)
            {
                if (column.DataPropertyName == "InvoiceID") 
                {
                    column.HeaderText = "Mã hóa đơn"; 
                }
                else if (column.DataPropertyName == "Name")
                {
                    column.HeaderText = "Tên món ăn";
                }
                else if (column.DataPropertyName == "Quantity")
                {
                    column.HeaderText = "Số lượng";
                }
                else if (column.DataPropertyName == "Price")
                {
                    column.HeaderText = "Đơn giá";
                }
                // Nếu bạn muốn ẩn một cột cụ thể, bạn có thể sử dụng:
                // column.Visible = false;
            }
        }

        // Sự kiện khi nút đóng được nhấp
        private void picClose_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }
    }
}

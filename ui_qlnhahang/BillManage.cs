using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ui_qlnhahang
{
    public partial class BillManage : Form
    {
        public BillManage()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        private void Form4_Load(object sender, EventArgs e)
        {
            dpFrom.Value = DateTime.Today;
            dpTo.Value = DateTime.Today.AddDays(1);

            dpFrom.Format = DateTimePickerFormat.Custom;
            dpFrom.CustomFormat = "dd/MM/yyyy";

            dpTo.Format = DateTimePickerFormat.Custom;
            dpTo.CustomFormat = "dd/MM/yyyy";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Tạo truy vấn SQL để lấy dữ liệu
            //    string query = "SELECT * FROM Bills";
            //    SqlCommand command = new SqlCommand(query, connection);

            //    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ truy vấn
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);

            //    // Tạo đối tượng DataTable để chứa dữ liệu từ cơ sở dữ liệu
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);

            //    // Gán DataTable làm nguồn dữ liệu cho DataGridView
            //    bunifuDataGridView1.DataSource = dataTable;
            //}

            //foreach (DataGridViewColumn column in bunifuDataGridView1.Columns)
            //{
            //    if (column.DataPropertyName == "ID") 
            //    {
            //        column.HeaderText = "Mã Hóa Đơn"; 
            //    }
            //    else if (column.DataPropertyName == "Name")
            //    {
            //        column.HeaderText = "Tên Hóa Đơn";
            //    }
            //    else if (column.DataPropertyName == "TableID")
            //    {
            //        column.HeaderText = "Số Bàn";
            //    }
            //    else if (column.DataPropertyName == "Amount")
            //    {
            //        column.HeaderText = "Tổng Tiền";
            //    }
            //    else if (column.DataPropertyName == "Status")
            //    {
            //        column.HeaderText = "Trạng Thái";
            //    }
            //    else if (column.DataPropertyName == "CheckoutDate")
            //    {
            //        column.HeaderText = "Ngày Xuất Đơn";
            //    }
            //    else if (column.DataPropertyName == "Account")
            //    {
            //        column.HeaderText = "Tài Khoản";
            //    }
            //}
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dpTo.Value < dpFrom.Value)
            {
                MessageBox.Show("Giá trị ngày không hợp lệ!");
                dpTo.Value = dpFrom.Value;
            } 
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dpFrom.Value > dpTo.Value)
            {
                dpTo.Value = dpFrom.Value;
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            //if (bunifuDataGridView1.SelectedRows.Count > 0) // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
            //{
            //    DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];
            //    int selectedBillId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            //    // Tạo và hiển thị form chi tiết hóa đơn
            //    BillDetails billDetailForm = new BillDetails(selectedBillId);
            //    billDetailForm.ShowDialog();
            //}
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dpFrom.Value;
            DateTime endDate = dpTo.Value;
            LoadBillReport(startDate, endDate);
        }
        private void LoadBillReport(DateTime startDate, DateTime endDate)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand("CreateBillReport", connection);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@StartDate", startDate);
            //    command.Parameters.AddWithValue("@EndDate", endDate);

            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);

            //    bunifuDataGridView1.DataSource = dataTable;
            //}
        }
    }
}

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
using static ui_qlnhahang.Order;
using static ui_qlnhahang.FormUltility;
using ui_qlnhahang.DAo;

namespace ui_qlnhahang
{
    public partial class BillManage : Form
    {
        // Truy vấn SQL chính để lấy dữ liệu từ bảng 'Bills'
        string mainquery = "select ID, TableID, Amount, Status,CheckoutDate, Account from [Bills]";

        // Constructor cho form BillManage
        public BillManage()
        {
            InitializeComponent();
        }

        // Sự kiện khi form load
        private void Form4_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho date picker và định dạng ngày
            dpFrom.Value = DateTime.Today;
            dpTo.Value = DateTime.Today.AddDays(1);

            dpFrom.Format = DateTimePickerFormat.Custom;
            dpFrom.CustomFormat = "dd/MM/yyyy";

            dpTo.Format = DateTimePickerFormat.Custom;
            dpTo.CustomFormat = "dd/MM/yyyy";

            // Lấy và hiển thị tất cả dữ liệu từ bảng 'Bills'
            GetAllData(mainquery, gvBill);
            gvBill.ClearSelection();

            // Định dạng ngày trong DataGridView
            handleFormatDate();
        }

        // Phương thức hỗ trợ để định dạng ngày trong DataGridView
        private void handleFormatDate()
        {
            foreach (DataGridViewColumn column in gvBill.Columns)
            {
                foreach (DataGridViewRow row in gvBill.Rows)
                {
                    if (row.Cells[column.Index].Value is DateTime)
                    {
                        column.DefaultCellStyle.Format = "dd/MM/yyyy";
                        return;
                    }
                }
            }
        }

        // Sự kiện khi giá trị ngày 'To' thay đổi
        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            // Đảm bảo ngày 'To' không sớm hơn ngày 'From'
            if (dpTo.Value < dpFrom.Value)
            {
                // Hiển thị hộp thoại thông báo lỗi
                MessBox mb = new MessBox("Giá trị ngày không hợp lệ!");
                mb.ShowDialog();
                // Đặt lại ngày 'To' bằng ngày 'From'
                dpTo.Value = dpFrom.Value;
            }
        }

        // Sự kiện khi giá trị ngày 'From' thay đổi
        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            // Đảm bảo ngày 'From' không muộn hơn ngày 'To'
            if (dpFrom.Value > dpTo.Value)
            {
                // Đặt ngày 'To' bằng ngày 'From'
                dpTo.Value = dpFrom.Value;
            }
        }

        // Sự kiện khi nút 'In hóa đơn' được nhấp
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (gvBill.SelectedRows.Count > 0)
            {
                // Lấy ID của hóa đơn được chọn
                int selectedBillID = Convert.ToInt32(gvBill.SelectedRows[0].Cells["billID"].Value);

                // Tạo form Chi tiết hóa đơn và truyền ID cho nó
                BillDetail detailForm = new BillDetail(selectedBillID);
                detailForm.ShowDialog();
            }
        }

        // Sự kiện khi nút 'Thống kê' được nhấp
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            // Lấy ngày bắt đầu và kết thúc để lọc dữ liệu
            DateTime startDate = dpFrom.Value;
            DateTime endDate = dpTo.Value;

            // Lọc hóa đơn dựa trên khoảng ngày đã chọn
            filterBill(startDate, endDate);
        }

        // Phương thức hỗ trợ để lọc hóa đơn dựa trên khoảng ngày
        private void filterBill(DateTime start, DateTime end)
        {
            // Tên của cột chứa ngày thanh toán
            string columnName = "billCheckout";

            // Duyệt qua từng hàng trong DataGridView
            foreach (DataGridViewRow row in gvBill.Rows)
            {
                // Kiểm tra xem giá trị trong cột đã chỉ định có phải là DateTime không
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value is DateTime)
                {
                    DateTime dateValue = (DateTime)row.Cells[columnName].Value;
                    // Hiển thị hoặc ẩn hàng dựa trên khoảng ngày
                    if (dateValue >= start && dateValue < end.AddDays(1))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        // Ẩn hàng nếu giá trị không phải là DateTime
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}

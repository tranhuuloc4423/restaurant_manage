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
    public partial class BillManage : Form
    {
        public BillManage()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // set current date for datepicker
            dpFrom.Value = DateTime.Today;
            dpTo.Value = DateTime.Today.AddDays(1);

            // reformat datepicker
            dpFrom.Format = DateTimePickerFormat.Custom;
            dpFrom.CustomFormat = "dd/MM/yyyy";

            dpTo.Format = DateTimePickerFormat.Custom;
            dpTo.CustomFormat = "dd/MM/yyyy";

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
            BillDetails billdetails = new BillDetails();
            
            // xử lý lấy dữ liệu người dùng chọn từ database để print hoá đơn 
            //
            //
            billdetails.ShowDialog();
        }
    }
}

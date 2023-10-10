﻿using System;
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

            string query = "select * from [Bills]";
            GetAllData(query, gvBill);
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
            if (gvBill.SelectedRows.Count > 0)
            {
                // Lấy ID của hóa đơn được chọn
                int selectedBillID = Convert.ToInt32(gvBill.SelectedRows[0].Cells["ID"].Value);

                // Tạo form Chi tiết hóa đơn và truyền ID cho nó
                BillDetail detailForm = new BillDetail(selectedBillID);
                detailForm.ShowDialog();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dpFrom.Value;
            DateTime endDate = dpTo.Value;
            filterBill(startDate, endDate);
        }

        private void filterBill(DateTime start, DateTime end)
        {

            string columnName = "billCheckout"; 
            foreach (DataGridViewRow row in gvBill.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value is DateTime)
                {
                    DateTime dateValue = (DateTime)row.Cells[columnName].Value;
                    if (dateValue >= start && dateValue < end.AddDays(1))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void LoadBillReport(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CreateBillReport", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
            }
        }
    }
}

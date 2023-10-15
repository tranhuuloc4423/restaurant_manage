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
        int billID;
        public BillDetail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public BillDetail(int selectedBillID)
        {
            InitializeComponent();
            CenterToScreen();
            billID = selectedBillID;
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();

        }

        private void LoadBillDetail()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSTR))
                {
                    connection.Open();

                    string query = @"SELECT BD.InvoiceID, F.Name, BD.Quantity, F.Price
                            FROM BillDetails BD
                            INNER JOIN Food F ON BD.FoodID = F.ID
                            WHERE BD.InvoiceID = @BillID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BillID", billID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bunifuDataGridView1.DataSource = dataTable;

                    SqlCommand command2 = new SqlCommand("Amount_GetById", connection);
                    command2.CommandType = CommandType.StoredProcedure;
                    command2.Parameters.AddWithValue("@ID", billID);
                    object result2 = command2.ExecuteScalar();
                    if (result2 != null)
                    {
                        lblTotal.Text = result2.ToString();
                    }
                    else
                    {
                        lblTotal.Text = "Không có dữ liệu";
                    }

                    SqlCommand command3 = new SqlCommand("Date_GetById", connection);
                    command3.CommandType = CommandType.StoredProcedure;
                    command3.Parameters.AddWithValue("@ID", billID);
                    object result3 = command3.ExecuteScalar();
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
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

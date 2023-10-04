using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui_qlnhahang.DAo
{
    public class DataProvider
    {
        
        
            private string connectionSTR = "Data Source=.;Initial Catalog=RestaurantManagement;Integrated Security=True";

            public DataTable ExecuteQuery(string query)
            {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    DataTable data = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);
                    connection.Close();
                    return data;
                }
            }

        
    }
}

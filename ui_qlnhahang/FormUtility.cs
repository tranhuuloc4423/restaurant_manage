using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;

namespace ui_qlnhahang
{
    public static class FormUtility
    {
        public static void GetAllData(string query, DataGridView gridView)
        {
            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                AddRowData(gridView, row.ItemArray);
            }

        }


        public static void AddRowData(DataGridView gridView, params object[] row)
        {
            gridView.Rows.Add(row);
        }
    }
}

using Bunifu.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;

namespace ui_qlnhahang
{
    public static class FormUltility
    {
        public static void GetAllData(string query, DataGridView gridView)
        {
            // reset
            gridView.Rows.Clear();
            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                AddRowData(gridView, row.ItemArray);
            }
            gridView.ClearSelection();
        }

        public static void GetAllData(string query, BunifuDropdown dropdown)
        {
            dropdown.Items.Clear();
            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                AddRowData(dropdown, row.ItemArray);
            }
        }

        public static DataTable GetTableData(string query)
        {
            DataProvider provider = new DataProvider();

            DataTable dataTable = provider.ExecuteQuery(query);
            return dataTable;
        }

        public static void AddRowData(BunifuDropdown dropdown, params object[] row)
        {
            dropdown.Items.Add(string.Join(", ", row));
        }


        public static void AddRowData(DataGridView gridView, params object[] row)
        {
            gridView.Rows.Add(row);
        }
    }
}

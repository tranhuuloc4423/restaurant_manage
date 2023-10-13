using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;
using BunifuDropdown = Bunifu.UI.WinForms.BunifuDropdown;

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

        public static void AddColumnData(DataGridView gridView, params object[] column)
        {
            gridView.Columns.Add("test", "");
        }



        public static void preventResise(BunifuDataGridView gridview)
        {
            gridview.AllowUserToResizeRows = false;
            gridview.AllowUserToResizeColumns = false;
        }

        public static void handleProcedure(string query, string name, string procedureParams, BunifuDataGridView gridview, string desc, object[] parameter = null)
        {
            DataProvider dataprovider = new DataProvider();
            dataprovider.ExecuteNonQueryProvider(name, procedureParams, parameter);
            //MessageBox.Show(desc);
            MessBox mb = new MessBox(desc);
            mb.Show();
            GetAllData(query, gridview);
        }

        public static void setStateButton(BunifuThinButton2 button, bool state)
        {
            if(!state)
            {
                button.Enabled = state;
                button.ActiveFillColor = Color.DarkSlateGray;
                button.IdleFillColor = Color.DarkSlateGray;
            } else
            {
                button.Enabled = state;
                button.IdleFillColor = Color.AliceBlue;
                button.ActiveFillColor = Color.AliceBlue;
            }
        }
    }
}

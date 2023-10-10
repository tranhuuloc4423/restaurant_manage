using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui_qlnhahang.DAo
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "Select * From dbo.Account where AccountName ='" + username + "' and Password='" + password + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkStaff(string username)
        {
            string query = "SELECT *\r\nFROM RoleAccount\r\nINNER JOIN Account ON Account.AccountName = RoleAccount.AccountName\r\nINNER JOIN Role ON Role.ID = RoleAccount.RoleID\r\nWHERE Account.AccountName = '"+username+"' and RoleID = 2;";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}

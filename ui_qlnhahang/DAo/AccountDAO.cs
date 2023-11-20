using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string query = "USP_LOGIN @userName , @passWord ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password});
            return result.Rows.Count > 0;
        }
        public bool checkStaff(string username)
        {
            string query = "SELECT *\r\nFROM RoleAccount\r\nINNER JOIN Account ON Account.AccountName = RoleAccount.AccountName\r\nINNER JOIN Role ON Role.ID = RoleAccount.RoleID\r\nWHERE Account.AccountName = '"+username+"' and RoleID = 2;";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string username, string displayname, string password ) 
        {
            string query = "Account_Update @AccountName  , @DisplayName , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, displayname, password });
            return result.Rows.Count > 0;
        }
        public class textToMd5
        {
            public static string converText(string text)
            {
                MD5 mD5 = MD5.Create();

                byte[] b = Encoding.ASCII.GetBytes(text);
                byte[] hash = mD5.ComputeHash(b);

                StringBuilder sb = new StringBuilder();
                foreach (var a in hash)
                {
                    sb.Append(a.ToString("x2"));
                }
                string rs = sb.ToString();
                return rs;
            }
        }
    }
}

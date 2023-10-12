using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class AccountManage : Form
    {
        string mainquery = "Select * from [Account]";
        string queryRoleName = "select [RoleName] from [Role]";
        string queryRole = "select *  from [Role]";
        public AccountManage()
        {
            InitializeComponent();
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            GetAllData(mainquery, gvAccount);
            preventResise(gvAccount);
            setStateButton(btnEdit, false);
        }

        private void gvAccount_ColumnHeadersHeightChanged(object sender, EventArgs e)
        {
            gvAccount.Rows[0].HeaderCell.Value = new Size(gvAccount.Rows[0].HeaderCell.Size.Width, 50);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUserName.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên tài khoản!");
                mb.ShowDialog();
                return;
            }

            if (String.IsNullOrEmpty(txtUserNameDisplay.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên hiển thị!");
                mb.ShowDialog();
                return;
            }

            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessBox mb = new MessBox("Vui lòng nhập mật khẩu!");
                mb.ShowDialog();
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}

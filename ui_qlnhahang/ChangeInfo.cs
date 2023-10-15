using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;

namespace ui_qlnhahang
{
    public partial class ChangeInfo : BorderForm
    {
        public ChangeInfo()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private string tk;
        public ChangeInfo(string tk)
        {
            InitializeComponent();
            CenterToScreen();
            this.tk = tk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(tk))
            {
                if (txtNewPass.Text.Equals(txtNewPassConfirm.Text))
                {
                    string username = txtUsername.Text;
                    string displayname = txtUsernameDisplay.Text;
                    string pass = txtNewPassConfirm.Text;
                    Accountupdate(username, displayname, pass);
                    MessBox mb = new MessBox("Cập nhật thành công!");
                    mb.ShowDialog();
                }
                else
                {
                    MessBox mb = new MessBox("Mật khẩu không trùng khớp!");
                    mb.ShowDialog();
                }
            }
            else {
                MessBox mb = new MessBox("Tài khoản không hợp lệ");
                mb.ShowDialog();
            }

        }
        void  Accountupdate(string username , string displayname, string pass)
        {
            AccountDAO.Instance.UpdateAccount(username, displayname, pass);
        }
    }
}

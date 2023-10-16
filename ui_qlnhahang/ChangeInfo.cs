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
using static ui_qlnhahang.FormUltility;

namespace ui_qlnhahang
{
    public partial class ChangeInfo : BorderForm
    {
        string mainquery = "select * from [Account]";
        public ChangeInfo()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private string tk;
        private string mk;
        public ChangeInfo(string tk, string mk)
        {
            InitializeComponent();
            CenterToScreen();
            this.tk = tk;
            this.mk = mk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(tk))
            {
                if(!txtCurrentPass.Text.Equals(mk))
                {
                    MessBox mb = new MessBox("Sai mật khẩu!");
                    mb.ShowDialog();
                    return;
                }
                if (txtNewPass.Text.Equals(txtNewPassConfirm.Text))
                {
                    string username = txtUsername.Text;
                    string displayname = txtUsernameDisplay.Text;
                    string pass = txtNewPassConfirm.Text;
                    Accountupdate(username, displayname, pass);
                    MessBox mb = new MessBox("Cập nhật thành công!");
                    mb.ShowDialog();
                    this.Close();
                    this.ParentForm.Close();
                    Login login = new Login();
                    login.ShowDialog();
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

        private void ChangeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}

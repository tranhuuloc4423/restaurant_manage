
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.DAo;
using ui_qlnhahang.Properties;
using System.Security.Cryptography;

namespace ui_qlnhahang
{
    public partial class Login : BorderForm
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public string tk ;
        public string mk ;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            tk = txttk.Text;
            mk = AccountDAO.textToMd5.converText(txtmk.Text);
            if (checkLogin(tk, mk))
            {
                this.Close();
            }
            else {
                MessBox mb = new MessBox("Sai tài khoản mật khẩu!");
                mb.ShowDialog();
            }
            
        }
        
        bool checkLogin(string tk, string mk)
        {
            return AccountDAO.Instance.Login(tk, mk);
        }

        public string gettk()
        {
            return txttk.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtmk.PasswordChar = '*';
            pbHide.BringToFront();
            this.KeyPreview = true;
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0')
            {
                txtmk.PasswordChar = '*';
                pbHide.BringToFront();
            }
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '*')
            {
                txtmk.PasswordChar = '\0';
                pbShow.BringToFront();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}

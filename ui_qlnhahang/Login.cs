
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

namespace ui_qlnhahang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            string mk = txtmk.Text;
            if (checkLogin(tk, mk))
            {
                Dashboard f = new Dashboard(tk);
                this.Hide();
                f.ShowDialog();
            }
            else MessageBox.Show("Sai tài khoản mật khẩu");
            
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

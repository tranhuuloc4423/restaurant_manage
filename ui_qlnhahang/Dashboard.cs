using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui_qlnhahang.Properties;
using System.Drawing;
namespace ui_qlnhahang
{
    public partial class Dashboard : Form
    {
        Form subForm = null;
        public Dashboard()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void navigation(Form form, string title)
        {
            if (subForm != null)
            {
                subForm.Dispose();
                panel.Controls.Remove(subForm);
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            subForm = form;
            panel.Controls.Add(subForm);
            form.Show();
            changeTitle(title);
        }

        private void changeTitle(String title)
        {
            lblTitle.Text = title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home form = new Home();
            navigation(form, "Chào mừng đến với nhà hàng Foodie");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn rời nhà hàng", "NHÀ HÀNG FOODIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            //CustomMessBox messbox = new CustomMessBox();
            //messbox.lblTitle.Text = "NHÀ HÀNG FOODIE";
            //messbox.lblContent.Text = "Bạn có muốn rời nhà hàng Foodie!";
            //messbox.ShowDialog();
        }

        private void btnFoodManage_Click(object sender, EventArgs e)
        {
            FoodManage form = new FoodManage();
            navigation(form, "Quản lý món ăn");
            pbHeader.Image = Resources.food;
        }

        private void btnCateManage_Click(object sender, EventArgs e)
        {
            CateManage form = new CateManage();
            navigation(form, "Quản lý danh mục món ăn");
            pbHeader.Image = Resources.food_delivery;
        }

        private void btnBillManage_Click(object sender, EventArgs e)
        {
            BillManage form = new BillManage();
            navigation(form,"Quản lý hoá đơn");
            pbHeader.Image = Resources.bill;
        }

        private void btnTableManage_Click(object sender, EventArgs e)
        {
            TableManage form = new TableManage();
            navigation(form, "Quản lý bàn ăn");
            pbHeader.Image = Resources.dining_table;
        }

        private void btnAccManage_Click(object sender, EventArgs e)
        {
            AccountManage form = new AccountManage();
            navigation(form, "Quản lý tài khoản");
            pbHeader.Image = Resources.user;
        }

        private void btnHomeManage_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            navigation(form, "Chào mừng đến với nhà hàng Foodie");
            pbHeader.Image = Resources.restaurant;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbHeader_Click(object sender, EventArgs e)
        {

        }
    }
}

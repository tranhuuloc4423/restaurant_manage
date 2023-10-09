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
using Bunifu.UI.WinForms.BunifuButton;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ui_qlnhahang
{
    
    public partial class Dashboard : Form
    {
        Form subForm = null;
        bool sidebarExpand;
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
            activeButton(title);
        }

        void activeButton(string title)
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control is BunifuButton)
                {
                    BunifuButton button = (BunifuButton)control;
                    if(button.Text == title)
                    {
                        button.IdleFillColor = Color.AliceBlue;
                    } else
                    {
                        button.IdleFillColor = Color.Transparent;
                    }
                }
            }
        }

        private void changeTitle(String title)
        {
            lblTitle.Text = title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home form = new Home();
            navigation(form, btnHome.Text);
            activeButton(btnHome.Text);
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
            navigation(form, btnFoodManage.Text);
            pbHeader.Image = Resources.food;
        }

        private void btnCateManage_Click(object sender, EventArgs e)
        {
            CateManage form = new CateManage();
            navigation(form, btnCateManage.Text);
            pbHeader.Image = Resources.food_delivery;
        }

        private void btnBillManage_Click(object sender, EventArgs e)
        {
            BillManage form = new BillManage();
            navigation(form, btnBillManage.Text);
            pbHeader.Image = Resources.bill;
        }

        private void btnTableManage_Click(object sender, EventArgs e)
        {
            TableManage form = new TableManage();
            navigation(form, btnTableManage.Text);
            pbHeader.Image = Resources.dining_table;
        }

        private void btnAccManage_Click(object sender, EventArgs e)
        {
            AccountManage form = new AccountManage();
            navigation(form, btnAccManage.Text);
            pbHeader.Image = Resources.user;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            navigation(form, btnOpenOrder.Text);
            pbHeader.Image = Resources.order_food;
        }
        

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {


            //if(sidebarExpand)
            //{
            //    sidebar.Width -= 10;
            //    if(sidebar.Width == sidebar.MinimumSize.Width)
            //    {
            //        sidebarExpand = false;
            //        sideBarTimer.Stop();
            //    }
            //} else
            //{
            //    sidebar.Width += 10;
            //    if (sidebar.Width == sidebar.MaximumSize.Width)
            //    {
            //        sidebarExpand = true;
            //        sideBarTimer.Stop();
            //    }
            //}
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            navigation(form, btnHome.Text);
            pbHeader.Image = Resources.restaurant;
        }

        private void panelButtons_Click(object sender, EventArgs e)
        {

        }
    }
}

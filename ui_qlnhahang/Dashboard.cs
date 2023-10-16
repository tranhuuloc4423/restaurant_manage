﻿using System;
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
using ui_qlnhahang.DAo;

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
        private string tk;
        public Dashboard(string tk)
        {
            this.tk = tk;
            InitializeComponent();
            CenterToScreen();
        }

        private void CenterFormInPanel(Form form, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;
            int formWidth = form.Width;
            int formHeight = form.Height;

            int left = (panelWidth - formWidth) / 2;
            int top = (panelHeight - formHeight) / 2;

            form.Location = new Point(left, top);
        }

        private void navigation(Form form, string title)
        {
            if (subForm != null)
            {
                subForm.Dispose();
                panel.Controls.Remove(subForm);
            }
            activeButton(title);
            Loading fl = new Loading();
            fl.ShowDialog();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            subForm = form;
            panel.Controls.Add(subForm);
            form.Show();
            changeTitle(title);
        }

        void activeButton(string title)
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;
                    if(button.Text == title)
                    {
                        button.BackColor = Color.AliceBlue;
                    } else
                    {
                        button.BackColor = Color.Transparent;
                    }
                }
            }
        }

        private void changeTitle(String title)
        {
            lblTitle.Text = title;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn rời nhà hàng", "NHÀ HÀNG FOODIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            CustomMessBox messbox = new CustomMessBox("Bạn có muốn rời nhà hàng FOODIE!");
            messbox.ShowDialog();
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

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            Order form = new Order(tk);
            navigation(form, btnOpenOrder.Text);
            pbHeader.Image = Resources.order_food;
            if (btnOpenOrder.Text.Equals("Bắt Đầu Order"))
            {
                handleStateBtn(false);
                btnOpenOrder.Text = "Kết Thúc Order";
            } else
            {
                handleStateBtn(true);
                btnOpenOrder.Text = "Bắt Đầu Order";
            }
        }

        void handleStateBtn(bool state)
        {
            btnHome.Enabled = state;
            btnAccManage.Enabled = state;
            btnBillManage.Enabled = state;
            btnCateManage.Enabled = state;
            btnTableManage.Enabled = state;
            btnFoodManage.Enabled = state;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            navigation(form, btnHome.Text);
            pbHeader.Image = Resources.restaurant;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Home form = new Home(tk);
            navigation(form, btnHome.Text);
            activeButton(btnHome.Text);
            if(checkStaff(tk))
            {
                btnAccManage.Enabled = false;
                btnBillManage.Enabled = false;
                btnCateManage.Enabled = false;
                btnTableManage.Enabled = false;
                btnFoodManage.Enabled = false;
            }
            lblaccountactive.Text =  "Tài khoản : " + tk ;
        }
        bool checkStaff(string tk)
        {
            return AccountDAO.Instance.checkStaff(tk);
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.Show();
        }
    }
}

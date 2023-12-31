﻿using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ui_qlnhahang.DAo;
using static ui_qlnhahang.FormUltility;
using static ui_qlnhahang.Order;

namespace ui_qlnhahang
{
    public partial class AccountManage : Form
    {
        string mainquery = "SELECT A.AccountName as Name, A.DisplayName as DisplayName, A.Password, R.RoleName\r\nFROM dbo.Account A\r\nJOIN dbo.RoleAccount RA ON A.AccountName = RA.AccountName\r\nJOIN dbo.Role R ON RA.RoleID = R.ID;";
        string queryRoleName = "select [RoleName] from [Role]";
        string queryRole = "select *  from [Role]";
        DataTable roles;
        DataTable list;
        BunifuTextBox[] myTextBoxes;
        public AccountManage()
        {
            InitializeComponent();
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            roles = GetTableData(queryRole);
            GetAllData(mainquery, gvAccount);
            GetAllData(queryRoleName, dpdType);
            dpdType.Text = dpdType.Items[0].ToString();

            myTextBoxes = new BunifuTextBox[] { txtUserName, txtUserNameDisplay, txtPass };
            handleResetTextbox(gvAccount, txtUserName, myTextBoxes);
        }

        private void gvAccount_ColumnHeadersHeightChanged(object sender, EventArgs e)
        {
            gvAccount.Rows[0].HeaderCell.Value = new Size(gvAccount.Rows[0].HeaderCell.Size.Width, 50);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text.Trim();
            string displayName = txtUserNameDisplay.Text.Trim();
            
            string pass = txtPass.Text.Trim();
            string passtomd5 = AccountDAO.textToMd5.converText(pass);
            if (String.IsNullOrEmpty(name))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên tài khoản!");
                mb.ShowDialog();
                txtUserName.Clear();
                return;
            }

            if (String.IsNullOrEmpty(displayName))
            {
                MessBox mb = new MessBox("Vui lòng nhập tên hiển thị!");
                mb.ShowDialog();
                txtUserNameDisplay.Clear();
                return;
            }

            if (String.IsNullOrEmpty(pass))
            {
                MessBox mb = new MessBox("Vui lòng nhập mật khẩu!");
                mb.ShowDialog();
                txtPass.Clear();
                return;
            }

            foreach (DataRow item in GetAllData(mainquery, gvAccount).Rows)
            {
                if (item["Name"].ToString().Equals(name))
                {
                    MessBox mb = new MessBox("Tên tài khoản đã có trong cơ sỡ dữ liệu!");
                    mb.ShowDialog();
                    handleResetTextbox(gvAccount, txtUserName, myTextBoxes);
                    return;
                }
            }


            string role = dpdType.Text;

            string procedureName = "InsertAccount";
            string procedureParams = "@AccountName @DisplayName @Password @RoleName";
            string desc = "Thêm tài khoản thành công";
            handleProcedure(mainquery, procedureName, procedureParams, gvAccount, desc, new object[] {name, displayName, passtomd5, role});
            handleResetTextbox(gvAccount, txtUserName, myTextBoxes);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvAccount.SelectedRows[0];
                string name = txtUserName.Text.Trim();
                string displayName = txtUserNameDisplay.Text.Trim();
                string pass = txtPass.Text.Trim();
                string passtomd5 = AccountDAO.textToMd5.converText(pass);
                if (String.IsNullOrEmpty(name))
                {
                    MessBox mb = new MessBox("Vui lòng nhập tên tài khoản!");
                    mb.ShowDialog();
                    txtUserName.Clear();
                    return;
                }

                if (String.IsNullOrEmpty(displayName))
                {
                    MessBox mb = new MessBox("Vui lòng nhập tên hiển thị!");
                    mb.ShowDialog();
                    txtUserNameDisplay.Clear();
                    return;
                }

                if (String.IsNullOrEmpty(pass))
                {
                    MessBox mb = new MessBox("Vui lòng nhập mật khẩu!");
                    mb.ShowDialog();
                    txtPass.Clear();
                    return;
                }
                
                int roleId = 0;
                string role = dpdType.Text;
                foreach (DataRow row in roles.Rows)
                {
                    if (row["RoleName"].ToString() == role)
                    {
                        roleId = Convert.ToInt32(row["ID"]);
                        break;
                    }
                }
                if (selectedRow.Cells[0].Value.ToString() != name)
                {
                    MessBox mb = new MessBox("Không thể đổi tên đăng nhập tài khoản!");
                    mb.ShowDialog();
                    txtUserName.Clear();
                    return;
                }

                string nameProcedure = "[UpdateAccountWithRoleID]";
                string procedureParams = "@AccountName @DisplayName @Password @NewRoleID";
                string desc = "Cập nhật tài khoản thành công!";
                handleProcedure(mainquery, nameProcedure, procedureParams, gvAccount, desc, new object[] { name, displayName, passtomd5, roleId });
                handleResetTextbox(gvAccount, txtUserName, myTextBoxes);
            } else
            {
                MessBox mb = new MessBox("Vui lòng chọn tài khoản muốn sửa!");
                mb.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvAccount.SelectedRows[0];
                object name = selectedRow.Cells[0].Value;

                string nameProcedure = "[DeleteAccountWithRole]";
                string procedureParams = "@AccountName";
                string desc = "Xoá tài khoản thành công!";
                handleProcedure(mainquery, nameProcedure, procedureParams, gvAccount, desc, new object[] { name });
                handleResetTextbox(gvAccount, txtUserName, myTextBoxes);
            }
            else
            {
                MessBox mb = new MessBox("Chọn tài khoản để xoá");
                mb.ShowDialog();
            }
        }

        private void gvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (gvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvAccount.SelectedRows[0];
                txtUserName.Text = selectedRow.Cells[0].Value.ToString();
                txtUserNameDisplay.Text = selectedRow.Cells[1].Value.ToString();
                dpdType.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            string columnName = "Name";
            handleFilter(gvAccount, txtSearch, mainquery, columnName);
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                handleResetTextbox(gvAccount, txtSearch, myTextBoxes);
            }
        }
    }
}

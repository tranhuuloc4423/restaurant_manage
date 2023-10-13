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
using static ui_qlnhahang.FormUltility;
using static ui_qlnhahang.Order;

namespace ui_qlnhahang
{
    public partial class AccountManage : Form
    {
        string mainquery = "Select * from [Account] ORDER BY AccountName";
        string queryRoleName = "select [RoleName] from [Role]";
        string queryRole = "select *  from [Role]";
        string queryAccToRole = "select * from [RoleAccount] ORDER BY AccountName";
        DataTable roles;
        public AccountManage()
        {
            InitializeComponent();
        }

        private void AccountManage_Load(object sender, EventArgs e)
        {
            roles = GetTableData(queryRole);
            GetAllData(mainquery, gvAccount);
            //GetAllData(queryAccToRoleName, gvAccount);
            GetAllData(queryRoleName, dpdType);
            dpdType.Text = dpdType.Items[0].ToString();
            preventResise(gvAccount);

            // setStateButton
            setStateButton(btnEdit, false);


            // Thêm cột mới vào GridView
            handleAddColumn();

            txtUserName.Clear();
            txtUserNameDisplay.Clear();
            txtPass.Clear();
        }

        private void gvAccount_ColumnHeadersHeightChanged(object sender, EventArgs e)
        {
            gvAccount.Rows[0].HeaderCell.Value = new Size(gvAccount.Rows[0].HeaderCell.Size.Width, 50);
        }

        private void handleAddColumn()
        {
            for (int rowIndex = 0; rowIndex < gvAccount.Rows.Count; rowIndex++)
            {
                int columnIndex = gvAccount.Columns["accountRole"].Index;
                string value = "";
                foreach (DataRow item in GetTableData(queryRole).Rows)
                {
                    if(GetTableData(queryAccToRole).Rows[rowIndex]["RoleID"].ToString() == item["ID"].ToString())
                    {
                        value = item["RoleName"].ToString();
                        break;
                    }
                }
                gvAccount.Rows[rowIndex].Cells[columnIndex].Value = value;
            }
        }

        void checkTextBoxNull()
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            checkTextBoxNull();
            string name = txtUserName.Text;
            string displayName = txtUserNameDisplay.Text;
            string pass = txtPass.Text;
            string role = dpdType.Text;

            string procedureName = "InsertAccount";
            string procedureParams = "@AccountName @DisplayName @Password @RoleName";
            string desc = "Thêm tài khoản thành công";
            handleProcedure(mainquery, procedureName, procedureParams, gvAccount, desc, new object[] {name, displayName, pass, role});
            handleAddColumn();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvAccount.SelectedRows[0];

                checkTextBoxNull();

                string name = txtUserName.Text.Trim();
                string displayName = txtUserNameDisplay.Text.Trim();
                string pass = txtPass.Text.Trim();
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

                string nameProcedure = "[UpdateAccountWithRoleID]";
                string procedureParams = "@AccountName @DisplayName @Password @NewRoleID";
                string desc = "Cập nhật tài khoản thành công!";
                handleProcedure(mainquery, nameProcedure, procedureParams, gvAccount, desc, new object[] { name, displayName, pass, roleId });
            }
            handleAddColumn();
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
            }
            else
            {
                MessBox mb = new MessBox("Chọn tài khoản để xoá");
                mb.ShowDialog();
            }
            handleAddColumn();
        }

        private void gvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (gvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvAccount.SelectedRows[0];
                txtUserName.Text = selectedRow.Cells[0].Value.ToString();
                txtUserNameDisplay.Text = selectedRow.Cells[1].Value.ToString();
                txtPass.Text = selectedRow.Cells[2].Value.ToString();
                // dropdown
            }
        }
    }
}

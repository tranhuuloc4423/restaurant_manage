namespace ui_qlnhahang
{
    partial class BillManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillManage));
            this.gvBill = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dpTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPrintBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnStatistic = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBill
            // 
            this.gvBill.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gvBill.AllowCustomTheming = false;
            this.gvBill.AllowUserToAddRows = false;
            this.gvBill.AllowUserToDeleteRows = false;
            this.gvBill.AllowUserToResizeColumns = false;
            this.gvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.gvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBill.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.gvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvBill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvBill.ColumnHeadersHeight = 40;
            this.gvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billID,
            this.billName,
            this.billTableID,
            this.billTotal,
            this.billState,
            this.billCheckout,
            this.billAccount});
            this.gvBill.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.gvBill.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvBill.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvBill.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.gvBill.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvBill.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvBill.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.gvBill.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvBill.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvBill.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvBill.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvBill.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvBill.CurrentTheme.Name = null;
            this.gvBill.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvBill.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvBill.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvBill.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.gvBill.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBill.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvBill.EnableHeadersVisualStyles = false;
            this.gvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.gvBill.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvBill.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvBill.HeaderForeColor = System.Drawing.Color.White;
            this.gvBill.Location = new System.Drawing.Point(43, 88);
            this.gvBill.MultiSelect = false;
            this.gvBill.Name = "gvBill";
            this.gvBill.ReadOnly = true;
            this.gvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvBill.RowHeadersVisible = false;
            this.gvBill.RowHeadersWidth = 51;
            this.gvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvBill.RowTemplate.Height = 40;
            this.gvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBill.Size = new System.Drawing.Size(975, 389);
            this.gvBill.TabIndex = 20;
            this.gvBill.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            // 
            // billID
            // 
            this.billID.HeaderText = "Mã hoá đơn";
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billName
            // 
            this.billName.HeaderText = "Tên hoá đơn";
            this.billName.Name = "billName";
            this.billName.ReadOnly = true;
            this.billName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billTableID
            // 
            this.billTableID.HeaderText = "Mã bàn";
            this.billTableID.Name = "billTableID";
            this.billTableID.ReadOnly = true;
            this.billTableID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billTableID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billTotal
            // 
            this.billTotal.HeaderText = "Tổng tiền";
            this.billTotal.Name = "billTotal";
            this.billTotal.ReadOnly = true;
            this.billTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billState
            // 
            this.billState.HeaderText = "Trạng thái";
            this.billState.Name = "billState";
            this.billState.ReadOnly = true;
            this.billState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billCheckout
            // 
            this.billCheckout.HeaderText = "Ngày tính";
            this.billCheckout.Name = "billCheckout";
            this.billCheckout.ReadOnly = true;
            this.billCheckout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billCheckout.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // billAccount
            // 
            this.billAccount.HeaderText = "Tài khoản";
            this.billAccount.Name = "billAccount";
            this.billAccount.ReadOnly = true;
            this.billAccount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.billAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dpFrom
            // 
            this.dpFrom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dpFrom.BorderRadius = 2;
            this.dpFrom.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFrom.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dpFrom.CalendarTitleBackColor = System.Drawing.Color.MediumTurquoise;
            this.dpFrom.Color = System.Drawing.Color.Navy;
            this.dpFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpFrom.DisabledColor = System.Drawing.Color.Gray;
            this.dpFrom.DisplayWeekNumbers = false;
            this.dpFrom.DPHeight = 0;
            this.dpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFrom.FillDatePicker = false;
            this.dpFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFrom.ForeColor = System.Drawing.Color.Black;
            this.dpFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dpFrom.Icon")));
            this.dpFrom.IconColor = System.Drawing.Color.IndianRed;
            this.dpFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpFrom.LeftTextMargin = 5;
            this.dpFrom.Location = new System.Drawing.Point(43, 31);
            this.dpFrom.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(294, 32);
            this.dpFrom.TabIndex = 40;
            this.dpFrom.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // dpTo
            // 
            this.dpTo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dpTo.BorderRadius = 2;
            this.dpTo.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dpTo.CalendarTitleBackColor = System.Drawing.Color.MediumTurquoise;
            this.dpTo.Color = System.Drawing.Color.Navy;
            this.dpTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpTo.DisabledColor = System.Drawing.Color.Gray;
            this.dpTo.DisplayWeekNumbers = false;
            this.dpTo.DPHeight = 0;
            this.dpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpTo.FillDatePicker = false;
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dpTo.ForeColor = System.Drawing.Color.Black;
            this.dpTo.Icon = ((System.Drawing.Image)(resources.GetObject("dpTo.Icon")));
            this.dpTo.IconColor = System.Drawing.Color.IndianRed;
            this.dpTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpTo.LeftTextMargin = 5;
            this.dpTo.Location = new System.Drawing.Point(404, 31);
            this.dpTo.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(239, 32);
            this.dpTo.TabIndex = 41;
            this.dpTo.Value = new System.DateTime(2023, 10, 8, 0, 0, 0, 0);
            this.dpTo.ValueChanged += new System.EventHandler(this.dpTo_ValueChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuLabel1.Location = new System.Drawing.Point(366, 25);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(11, 36);
            this.bunifuLabel1.TabIndex = 44;
            this.bunifuLabel1.Text = "-";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.ActiveBorderThickness = 2;
            this.btnPrintBill.ActiveCornerRadius = 20;
            this.btnPrintBill.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnPrintBill.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnPrintBill.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrintBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.BackgroundImage")));
            this.btnPrintBill.ButtonText = "In Hoá Đơn";
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.Black;
            this.btnPrintBill.IdleBorderThickness = 2;
            this.btnPrintBill.IdleCornerRadius = 20;
            this.btnPrintBill.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.IdleForecolor = System.Drawing.Color.Black;
            this.btnPrintBill.IdleLineColor = System.Drawing.Color.Black;
            this.btnPrintBill.Location = new System.Drawing.Point(898, 21);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(120, 50);
            this.btnPrintBill.TabIndex = 49;
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.ActiveBorderThickness = 2;
            this.btnStatistic.ActiveCornerRadius = 20;
            this.btnStatistic.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnStatistic.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnStatistic.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnStatistic.BackColor = System.Drawing.Color.LightBlue;
            this.btnStatistic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistic.BackgroundImage")));
            this.btnStatistic.ButtonText = "Thống Kê";
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.IdleBorderThickness = 2;
            this.btnStatistic.IdleCornerRadius = 20;
            this.btnStatistic.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnStatistic.IdleForecolor = System.Drawing.Color.Black;
            this.btnStatistic.IdleLineColor = System.Drawing.Color.Black;
            this.btnStatistic.Location = new System.Drawing.Point(742, 21);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(120, 50);
            this.btnStatistic.TabIndex = 48;
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // BillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1039, 576);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.dpFrom);
            this.Controls.Add(this.gvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillManage";
            this.Text = "Thống kê hoá đơn";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView gvBill;
        private Bunifu.UI.WinForms.BunifuDatePicker dpFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker dpTo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billName;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn billState;
        private System.Windows.Forms.DataGridViewTextBoxColumn billCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn billAccount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrintBill;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStatistic;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillManage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gvBill = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnThongKe = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dpFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dpTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPrintBill = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBill
            // 
            this.gvBill.AllowCustomTheming = false;
            this.gvBill.AllowUserToAddRows = false;
            this.gvBill.AllowUserToDeleteRows = false;
            this.gvBill.AllowUserToResizeColumns = false;
            this.gvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBill.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.gvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvBill.EnableHeadersVisualStyles = false;
            this.gvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.gvBill.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvBill.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvBill.HeaderForeColor = System.Drawing.Color.White;
            this.gvBill.Location = new System.Drawing.Point(43, 88);
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
            // btnThongKe
            // 
            this.btnThongKe.AllowAnimations = true;
            this.btnThongKe.AllowMouseEffects = true;
            this.btnThongKe.AllowToggling = false;
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongKe.AnimationSpeed = 200;
            this.btnThongKe.AutoGenerateColors = false;
            this.btnThongKe.AutoRoundBorders = false;
            this.btnThongKe.AutoSizeLeftIcon = true;
            this.btnThongKe.AutoSizeRightIcon = true;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BackColor1 = System.Drawing.Color.AliceBlue;
            this.btnThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.BackgroundImage")));
            this.btnThongKe.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThongKe.ButtonText = "Thống kê";
            this.btnThongKe.ButtonTextMarginLeft = 0;
            this.btnThongKe.ColorContrastOnClick = 45;
            this.btnThongKe.ColorContrastOnHover = 45;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnThongKe.CustomizableEdges = borderEdges1;
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.DisabledFillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnThongKe.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThongKe.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThongKe.IconMarginLeft = 11;
            this.btnThongKe.IconPadding = 10;
            this.btnThongKe.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThongKe.IconSize = 25;
            this.btnThongKe.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.IdleBorderRadius = 20;
            this.btnThongKe.IdleBorderThickness = 1;
            this.btnThongKe.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.IdleIconLeftImage = null;
            this.btnThongKe.IdleIconRightImage = null;
            this.btnThongKe.IndicateFocus = false;
            this.btnThongKe.Location = new System.Drawing.Point(740, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnDisabledState.BorderRadius = 20;
            this.btnThongKe.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThongKe.OnDisabledState.BorderThickness = 1;
            this.btnThongKe.OnDisabledState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnDisabledState.IconLeftImage = null;
            this.btnThongKe.OnDisabledState.IconRightImage = null;
            this.btnThongKe.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.onHoverState.BorderRadius = 20;
            this.btnThongKe.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThongKe.onHoverState.BorderThickness = 1;
            this.btnThongKe.onHoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnThongKe.onHoverState.IconLeftImage = null;
            this.btnThongKe.onHoverState.IconRightImage = null;
            this.btnThongKe.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnIdleState.BorderRadius = 20;
            this.btnThongKe.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThongKe.OnIdleState.BorderThickness = 1;
            this.btnThongKe.OnIdleState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.OnIdleState.ForeColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnIdleState.IconLeftImage = null;
            this.btnThongKe.OnIdleState.IconRightImage = null;
            this.btnThongKe.OnPressedState.BorderColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnPressedState.BorderRadius = 20;
            this.btnThongKe.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThongKe.OnPressedState.BorderThickness = 1;
            this.btnThongKe.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnThongKe.OnPressedState.ForeColor = System.Drawing.Color.Empty;
            this.btnThongKe.OnPressedState.IconLeftImage = null;
            this.btnThongKe.OnPressedState.IconRightImage = null;
            this.btnThongKe.Size = new System.Drawing.Size(122, 32);
            this.btnThongKe.TabIndex = 39;
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKe.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongKe.TextMarginLeft = 0;
            this.btnThongKe.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThongKe.UseDefaultRadiusAndThickness = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.dpTo.Size = new System.Drawing.Size(296, 32);
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
            this.btnPrintBill.AllowAnimations = true;
            this.btnPrintBill.AllowMouseEffects = true;
            this.btnPrintBill.AllowToggling = false;
            this.btnPrintBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintBill.AnimationSpeed = 200;
            this.btnPrintBill.AutoGenerateColors = false;
            this.btnPrintBill.AutoRoundBorders = false;
            this.btnPrintBill.AutoSizeLeftIcon = true;
            this.btnPrintBill.AutoSizeRightIcon = true;
            this.btnPrintBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.BackColor1 = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.BackgroundImage")));
            this.btnPrintBill.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintBill.ButtonText = "In hoá đơn";
            this.btnPrintBill.ButtonTextMarginLeft = 0;
            this.btnPrintBill.ColorContrastOnClick = 45;
            this.btnPrintBill.ColorContrastOnHover = 45;
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPrintBill.CustomizableEdges = borderEdges2;
            this.btnPrintBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintBill.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.DisabledFillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPrintBill.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrintBill.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBill.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrintBill.IconMarginLeft = 11;
            this.btnPrintBill.IconPadding = 10;
            this.btnPrintBill.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintBill.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrintBill.IconSize = 25;
            this.btnPrintBill.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.IdleBorderRadius = 20;
            this.btnPrintBill.IdleBorderThickness = 1;
            this.btnPrintBill.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.IdleIconLeftImage = null;
            this.btnPrintBill.IdleIconRightImage = null;
            this.btnPrintBill.IndicateFocus = false;
            this.btnPrintBill.Location = new System.Drawing.Point(896, 25);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnDisabledState.BorderRadius = 20;
            this.btnPrintBill.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintBill.OnDisabledState.BorderThickness = 1;
            this.btnPrintBill.OnDisabledState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.OnDisabledState.ForeColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnDisabledState.IconLeftImage = null;
            this.btnPrintBill.OnDisabledState.IconRightImage = null;
            this.btnPrintBill.onHoverState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.onHoverState.BorderRadius = 20;
            this.btnPrintBill.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintBill.onHoverState.BorderThickness = 1;
            this.btnPrintBill.onHoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnPrintBill.onHoverState.IconLeftImage = null;
            this.btnPrintBill.onHoverState.IconRightImage = null;
            this.btnPrintBill.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnIdleState.BorderRadius = 20;
            this.btnPrintBill.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintBill.OnIdleState.BorderThickness = 1;
            this.btnPrintBill.OnIdleState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.OnIdleState.ForeColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnIdleState.IconLeftImage = null;
            this.btnPrintBill.OnIdleState.IconRightImage = null;
            this.btnPrintBill.OnPressedState.BorderColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnPressedState.BorderRadius = 20;
            this.btnPrintBill.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrintBill.OnPressedState.BorderThickness = 1;
            this.btnPrintBill.OnPressedState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnPrintBill.OnPressedState.ForeColor = System.Drawing.Color.Empty;
            this.btnPrintBill.OnPressedState.IconLeftImage = null;
            this.btnPrintBill.OnPressedState.IconRightImage = null;
            this.btnPrintBill.Size = new System.Drawing.Size(122, 32);
            this.btnPrintBill.TabIndex = 45;
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintBill.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintBill.TextMarginLeft = 0;
            this.btnPrintBill.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrintBill.UseDefaultRadiusAndThickness = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // billID
            // 
            this.billID.HeaderText = "Mã hoá đơn";
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            // 
            // billName
            // 
            this.billName.HeaderText = "Tên hoá đơn";
            this.billName.Name = "billName";
            this.billName.ReadOnly = true;
            // 
            // billTableID
            // 
            this.billTableID.HeaderText = "Mã bàn";
            this.billTableID.Name = "billTableID";
            this.billTableID.ReadOnly = true;
            // 
            // billTotal
            // 
            this.billTotal.HeaderText = "Tổng tiền";
            this.billTotal.Name = "billTotal";
            this.billTotal.ReadOnly = true;
            // 
            // billState
            // 
            this.billState.HeaderText = "Trạng thái";
            this.billState.Name = "billState";
            this.billState.ReadOnly = true;
            // 
            // billCheckout
            // 
            this.billCheckout.HeaderText = "Ngày tính";
            this.billCheckout.Name = "billCheckout";
            this.billCheckout.ReadOnly = true;
            // 
            // billAccount
            // 
            this.billAccount.HeaderText = "Tài khoản";
            this.billAccount.Name = "billAccount";
            this.billAccount.ReadOnly = true;
            // 
            // BillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1039, 576);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.dpFrom);
            this.Controls.Add(this.btnThongKe);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThongKe;
        private Bunifu.UI.WinForms.BunifuDatePicker dpFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker dpTo;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrintBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billName;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn billState;
        private System.Windows.Forms.DataGridViewTextBoxColumn billCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn billAccount;
    }
}
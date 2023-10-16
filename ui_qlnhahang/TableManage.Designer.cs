namespace ui_qlnhahang
{
    partial class TableManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gvTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtNameTable = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(676, 225);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(77, 23);
            this.bunifuLabel1.TabIndex = 27;
            this.bunifuLabel1.Text = "Tên bàn:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gvTable
            // 
            this.gvTable.AllowCustomTheming = false;
            this.gvTable.AllowUserToAddRows = false;
            this.gvTable.AllowUserToDeleteRows = false;
            this.gvTable.AllowUserToResizeColumns = false;
            this.gvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTable.BackgroundColor = System.Drawing.Color.Lavender;
            this.gvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvTable.ColumnHeadersHeight = 40;
            this.gvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableID,
            this.TableName});
            this.gvTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.gvTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.gvTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvTable.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.gvTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvTable.CurrentTheme.Name = null;
            this.gvTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.gvTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvTable.EnableHeadersVisualStyles = false;
            this.gvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.gvTable.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvTable.HeaderForeColor = System.Drawing.Color.White;
            this.gvTable.Location = new System.Drawing.Point(22, 77);
            this.gvTable.MultiSelect = false;
            this.gvTable.Name = "gvTable";
            this.gvTable.ReadOnly = true;
            this.gvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTable.RowHeadersVisible = false;
            this.gvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvTable.RowTemplate.Height = 40;
            this.gvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTable.Size = new System.Drawing.Size(627, 389);
            this.gvTable.TabIndex = 19;
            this.gvTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            this.gvTable.SelectionChanged += new System.EventHandler(this.gvTable_SelectionChanged);
            // 
            // tableID
            // 
            this.tableID.FillWeight = 76.14214F;
            this.tableID.HeaderText = "ID";
            this.tableID.Name = "tableID";
            this.tableID.ReadOnly = true;
            this.tableID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TableName
            // 
            this.TableName.FillWeight = 111.9289F;
            this.TableName.HeaderText = "Tên bàn";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(676, 254);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(331, 14);
            this.bunifuSeparator1.TabIndex = 26;
            // 
            // txtNameTable
            // 
            this.txtNameTable.AcceptsReturn = false;
            this.txtNameTable.AcceptsTab = false;
            this.txtNameTable.AnimationSpeed = 200;
            this.txtNameTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNameTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNameTable.BackColor = System.Drawing.Color.Transparent;
            this.txtNameTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNameTable.BackgroundImage")));
            this.txtNameTable.BorderColorActive = System.Drawing.Color.Transparent;
            this.txtNameTable.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.txtNameTable.BorderColorHover = System.Drawing.Color.Transparent;
            this.txtNameTable.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtNameTable.BorderRadius = 1;
            this.txtNameTable.BorderThickness = 1;
            this.txtNameTable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNameTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTable.DefaultFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTable.DefaultText = "";
            this.txtNameTable.FillColor = System.Drawing.Color.LightBlue;
            this.txtNameTable.HideSelection = true;
            this.txtNameTable.IconLeft = null;
            this.txtNameTable.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTable.IconPadding = 10;
            this.txtNameTable.IconRight = null;
            this.txtNameTable.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameTable.Lines = new string[0];
            this.txtNameTable.Location = new System.Drawing.Point(771, 225);
            this.txtNameTable.MaxLength = 32767;
            this.txtNameTable.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNameTable.Modified = false;
            this.txtNameTable.Multiline = false;
            this.txtNameTable.Name = "txtNameTable";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNameTable.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNameTable.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNameTable.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.LightBlue;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNameTable.OnIdleState = stateProperties4;
            this.txtNameTable.Padding = new System.Windows.Forms.Padding(3);
            this.txtNameTable.PasswordChar = '\0';
            this.txtNameTable.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNameTable.PlaceholderText = "";
            this.txtNameTable.ReadOnly = false;
            this.txtNameTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameTable.SelectedText = "";
            this.txtNameTable.SelectionLength = 0;
            this.txtNameTable.SelectionStart = 0;
            this.txtNameTable.ShortcutsEnabled = true;
            this.txtNameTable.Size = new System.Drawing.Size(236, 23);
            this.txtNameTable.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNameTable.TabIndex = 25;
            this.txtNameTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameTable.TextMarginBottom = 0;
            this.txtNameTable.TextMarginLeft = 3;
            this.txtNameTable.TextMarginTop = 0;
            this.txtNameTable.TextPlaceholder = "";
            this.txtNameTable.UseSystemPasswordChar = false;
            this.txtNameTable.WordWrap = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "50.000đ",
            "60.000đ",
            "70.000đ",
            "80.000đ",
            "90.000đ",
            "100.000đ",
            "120.000đ"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.Black;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.Black;
            this.txtSearch.BorderColorHover = System.Drawing.Color.Black;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.LightBlue;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(801, 109);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.Black;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Black;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Black;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.LightBlue;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Bàn...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(200, 55);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Bàn...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(676, 126);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(83, 23);
            this.bunifuLabel2.TabIndex = 39;
            this.bunifuLabel2.Text = "Tìm kiếm:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 2;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnDelete.BackColor = System.Drawing.Color.LightBlue;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xoá";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.IdleBorderThickness = 2;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.IdleForecolor = System.Drawing.Color.Black;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(907, 358);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 2;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.IdleBorderThickness = 2;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnEdit.IdleForecolor = System.Drawing.Color.Black;
            this.btnEdit.IdleLineColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(788, 358);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 50);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 2;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Thêm";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IdleBorderThickness = 2;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Black;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(676, 358);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TableManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1039, 576);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.txtNameTable);
            this.Controls.Add(this.gvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableManage";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.TableManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNameTable;
        private Bunifu.UI.WinForms.BunifuDataGridView gvTable;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
    }
}
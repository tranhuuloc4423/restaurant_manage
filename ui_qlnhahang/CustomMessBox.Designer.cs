namespace ui_qlnhahang
{
    partial class CustomMessBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessBox));
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnExit = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExit2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(106, 48);
            this.lblTitle.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(192, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "bunifuLabel1";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnExit
            // 
            this.btnExit.AllowFocused = false;
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSizeHeight = true;
            this.btnExit.BorderRadius = 20;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.IsCircle = true;
            this.btnExit.Location = new System.Drawing.Point(398, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.AllowFocused = false;
            this.pbIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbIcon.AutoSizeHeight = true;
            this.pbIcon.BorderRadius = 30;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.IsCircle = true;
            this.pbIcon.Location = new System.Drawing.Point(23, 58);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 60);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            this.pbIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 2;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Ok";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.IdleBorderThickness = 2;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnConfirm.IdleForecolor = System.Drawing.Color.Black;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(70, 10);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 50);
            this.btnConfirm.TabIndex = 43;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.ActiveBorderThickness = 2;
            this.btnExit2.ActiveCornerRadius = 20;
            this.btnExit2.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnExit2.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnExit2.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnExit2.BackColor = System.Drawing.Color.Transparent;
            this.btnExit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit2.BackgroundImage")));
            this.btnExit2.ButtonText = "Cancel";
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.ForeColor = System.Drawing.Color.Black;
            this.btnExit2.IdleBorderThickness = 2;
            this.btnExit2.IdleCornerRadius = 20;
            this.btnExit2.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnExit2.IdleForecolor = System.Drawing.Color.Black;
            this.btnExit2.IdleLineColor = System.Drawing.Color.Black;
            this.btnExit2.Location = new System.Drawing.Point(272, 10);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(100, 50);
            this.btnExit2.TabIndex = 44;
            this.btnExit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit2);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 67);
            this.panel1.TabIndex = 45;
            // 
            // CustomMessBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "CustomMessBox";
            this.Text = "Ư";
            this.Load += new System.EventHandler(this.CustomMessBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuPictureBox btnExit;
        private Bunifu.UI.WinForms.BunifuPictureBox pbIcon;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit2;
        private System.Windows.Forms.Panel panel1;
    }
}
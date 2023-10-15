namespace ui_qlnhahang
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChangePass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.ActiveBorderThickness = 2;
            this.btnInfo.ActiveCornerRadius = 20;
            this.btnInfo.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnInfo.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnInfo.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInfo.ButtonText = "Thông Tin";
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.IdleBorderThickness = 2;
            this.btnInfo.IdleCornerRadius = 20;
            this.btnInfo.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnInfo.IdleForecolor = System.Drawing.Color.Black;
            this.btnInfo.IdleLineColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(81, 47);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(150, 75);
            this.btnInfo.TabIndex = 43;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.ActiveBorderThickness = 2;
            this.btnChangePass.ActiveCornerRadius = 20;
            this.btnChangePass.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnChangePass.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnChangePass.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePass.BackgroundImage")));
            this.btnChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePass.ButtonText = "Đổi Thông Tin";
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.IdleBorderThickness = 2;
            this.btnChangePass.IdleCornerRadius = 20;
            this.btnChangePass.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnChangePass.IdleForecolor = System.Drawing.Color.Black;
            this.btnChangePass.IdleLineColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(81, 193);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(150, 75);
            this.btnChangePass.TabIndex = 44;
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 2;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.AliceBlue;
            this.btnExit.ActiveForecolor = System.Drawing.Color.Coral;
            this.btnExit.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.ButtonText = "Thoát";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.IdleBorderThickness = 2;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.btnExit.IdleForecolor = System.Drawing.Color.Black;
            this.btnExit.IdleLineColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(81, 343);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 75);
            this.btnExit.TabIndex = 45;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Location = new System.Drawing.Point(633, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 460);
            this.panel1.TabIndex = 46;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 576);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangePass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace Admin.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckinButton = new MaterialSkin.Controls.MaterialButton();
            this.logoutButton = new MaterialSkin.Controls.MaterialButton();
            this.buttonXLVP = new System.Windows.Forms.Button();
            this.buttonQLphieumuon = new System.Windows.Forms.Button();
            this.buttonQLdatcho = new System.Windows.Forms.Button();
            this.buttonQLthietbi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CheckinButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.buttonXLVP);
            this.panel1.Controls.Add(this.buttonQLphieumuon);
            this.panel1.Controls.Add(this.buttonQLdatcho);
            this.panel1.Controls.Add(this.buttonQLthietbi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 797);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(2, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Quản lý loại thiết bị";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckinButton
            // 
            this.CheckinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CheckinButton.Depth = 0;
            this.CheckinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckinButton.HighEmphasis = true;
            this.CheckinButton.Icon = null;
            this.CheckinButton.Location = new System.Drawing.Point(80, 678);
            this.CheckinButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CheckinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckinButton.Name = "CheckinButton";
            this.CheckinButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CheckinButton.Size = new System.Drawing.Size(87, 36);
            this.CheckinButton.TabIndex = 7;
            this.CheckinButton.Text = "Check in";
            this.CheckinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CheckinButton.UseAccentColor = false;
            this.CheckinButton.UseVisualStyleBackColor = true;
            this.CheckinButton.Click += new System.EventHandler(this.CheckinButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logoutButton.Depth = 0;
            this.logoutButton.HighEmphasis = true;
            this.logoutButton.Icon = null;
            this.logoutButton.Location = new System.Drawing.Point(73, 741);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logoutButton.Size = new System.Drawing.Size(103, 36);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Đăng xuất";
            this.logoutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logoutButton.UseAccentColor = false;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // buttonXLVP
            // 
            this.buttonXLVP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonXLVP.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonXLVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXLVP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonXLVP.Location = new System.Drawing.Point(0, 441);
            this.buttonXLVP.Name = "buttonXLVP";
            this.buttonXLVP.Size = new System.Drawing.Size(258, 61);
            this.buttonXLVP.TabIndex = 5;
            this.buttonXLVP.Text = "Xử lý vi phạm";
            this.buttonXLVP.UseVisualStyleBackColor = false;
            this.buttonXLVP.Click += new System.EventHandler(this.buttonXLVP_Click);
            // 
            // buttonQLphieumuon
            // 
            this.buttonQLphieumuon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonQLphieumuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonQLphieumuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLphieumuon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQLphieumuon.Location = new System.Drawing.Point(0, 374);
            this.buttonQLphieumuon.Name = "buttonQLphieumuon";
            this.buttonQLphieumuon.Size = new System.Drawing.Size(258, 61);
            this.buttonQLphieumuon.TabIndex = 4;
            this.buttonQLphieumuon.Text = "Quản lý phiếu mượn";
            this.buttonQLphieumuon.UseVisualStyleBackColor = false;
            this.buttonQLphieumuon.Click += new System.EventHandler(this.buttonQLphieumuon_Click);
            // 
            // buttonQLdatcho
            // 
            this.buttonQLdatcho.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonQLdatcho.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonQLdatcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLdatcho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQLdatcho.Location = new System.Drawing.Point(3, 508);
            this.buttonQLdatcho.Name = "buttonQLdatcho";
            this.buttonQLdatcho.Size = new System.Drawing.Size(258, 61);
            this.buttonQLdatcho.TabIndex = 3;
            this.buttonQLdatcho.Text = "Quản lý đặt chỗ";
            this.buttonQLdatcho.UseVisualStyleBackColor = false;
            this.buttonQLdatcho.Click += new System.EventHandler(this.buttonQLdatcho_Click);
            // 
            // buttonQLthietbi
            // 
            this.buttonQLthietbi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonQLthietbi.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonQLthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLthietbi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQLthietbi.Location = new System.Drawing.Point(0, 240);
            this.buttonQLthietbi.Name = "buttonQLthietbi";
            this.buttonQLthietbi.Size = new System.Drawing.Size(258, 61);
            this.buttonQLthietbi.TabIndex = 2;
            this.buttonQLthietbi.Text = "Quản lý thiết bị";
            this.buttonQLthietbi.UseVisualStyleBackColor = false;
            this.buttonQLthietbi.Click += new System.EventHandler(this.buttonQLthietbi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quản lý người dùng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 125);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thư viện";
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(268, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1040, 797);
            this.contentPanel.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 800);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonQLthietbi;
        private System.Windows.Forms.Button buttonQLphieumuon;
        private System.Windows.Forms.Button buttonQLdatcho;
        private System.Windows.Forms.Button buttonXLVP;
        private MaterialSkin.Controls.MaterialButton logoutButton;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialButton CheckinButton;
        private System.Windows.Forms.Button button2;
    }
}
namespace Admin.Views
{
    partial class DeviceForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListDevice = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.available = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListDevice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1013, 678);
            this.panel2.TabIndex = 7;
            // 
            // ListDevice
            // 
            this.ListDevice.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.ListDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDevice.Location = new System.Drawing.Point(5, 5);
            this.ListDevice.Name = "ListDevice";
            this.ListDevice.RowHeadersVisible = false;
            this.ListDevice.RowHeadersWidth = 51;
            this.ListDevice.RowTemplate.Height = 24;
            this.ListDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDevice.Size = new System.Drawing.Size(1003, 668);
            this.ListDevice.TabIndex = 0;
            this.ListDevice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDevice_CellDoubleClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "Select";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.available);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.excel);
            this.panel1.Controls.Add(this.Reload);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1013, 86);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa nhiều";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.SpringGreen;
            this.excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel.Location = new System.Drawing.Point(861, 10);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(126, 59);
            this.excel.TabIndex = 4;
            this.excel.Text = " Excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.DarkViolet;
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Location = new System.Drawing.Point(357, 10);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(144, 59);
            this.Reload.TabIndex = 3;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkViolet;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(183, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(144, 59);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkViolet;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(11, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 59);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // available
            // 
            this.available.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.available.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.available.Depth = 0;
            this.available.HighEmphasis = true;
            this.available.Icon = null;
            this.available.Location = new System.Drawing.Point(521, 25);
            this.available.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.available.MinimumSize = new System.Drawing.Size(90, 0);
            this.available.MouseState = MaterialSkin.MouseState.HOVER;
            this.available.Name = "available";
            this.available.NoAccentTextColor = System.Drawing.Color.Empty;
            this.available.Size = new System.Drawing.Size(109, 36);
            this.available.TabIndex = 7;
            this.available.Text = "được mượn";
            this.available.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.available.UseAccentColor = false;
            this.available.UseVisualStyleBackColor = true;
            this.available.Click += new System.EventHandler(this.available_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 764);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListDevice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private MaterialSkin.Controls.MaterialButton available;
    }
}
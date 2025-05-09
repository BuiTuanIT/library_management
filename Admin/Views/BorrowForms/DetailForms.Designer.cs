namespace Admin.Views.BorrowForms
{
    partial class DetailForms
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
            this.exitbutton = new MaterialSkin.Controls.MaterialButton();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.actualReturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.returnDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrowDay = new System.Windows.Forms.DateTimePicker();
            this.cbbUser = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbDevice = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.Id = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(1, 647);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 68);
            this.panel2.TabIndex = 5;
            // 
            // exitbutton
            // 
            this.exitbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitbutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitbutton.Depth = 0;
            this.exitbutton.HighEmphasis = true;
            this.exitbutton.Icon = null;
            this.exitbutton.Location = new System.Drawing.Point(27, 15);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitbutton.Size = new System.Drawing.Size(69, 36);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Thoát";
            this.exitbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitbutton.UseAccentColor = false;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(436, 15);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSave.Size = new System.Drawing.Size(64, 36);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSave.UseAccentColor = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.actualReturn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.returnDay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BorrowDay);
            this.panel1.Controls.Add(this.cbbUser);
            this.panel1.Controls.Add(this.cbbDevice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 638);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Actual Return";
            // 
            // actualReturn
            // 
            this.actualReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualReturn.Location = new System.Drawing.Point(190, 414);
            this.actualReturn.MinimumSize = new System.Drawing.Size(4, 40);
            this.actualReturn.Name = "actualReturn";
            this.actualReturn.Size = new System.Drawing.Size(310, 40);
            this.actualReturn.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Return Day";
            // 
            // returnDay
            // 
            this.returnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDay.Location = new System.Drawing.Point(190, 338);
            this.returnDay.MinimumSize = new System.Drawing.Size(4, 40);
            this.returnDay.Name = "returnDay";
            this.returnDay.Size = new System.Drawing.Size(310, 40);
            this.returnDay.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Borrow Day";
            // 
            // BorrowDay
            // 
            this.BorrowDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowDay.Location = new System.Drawing.Point(190, 266);
            this.BorrowDay.MinimumSize = new System.Drawing.Size(4, 40);
            this.BorrowDay.Name = "BorrowDay";
            this.BorrowDay.Size = new System.Drawing.Size(310, 40);
            this.BorrowDay.TabIndex = 13;
            // 
            // cbbUser
            // 
            this.cbbUser.AutoResize = false;
            this.cbbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbUser.Depth = 0;
            this.cbbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbUser.DropDownHeight = 174;
            this.cbbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUser.DropDownWidth = 121;
            this.cbbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.IntegralHeight = false;
            this.cbbUser.ItemHeight = 43;
            this.cbbUser.Location = new System.Drawing.Point(190, 183);
            this.cbbUser.MaxDropDownItems = 4;
            this.cbbUser.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(310, 49);
            this.cbbUser.StartIndex = 0;
            this.cbbUser.TabIndex = 12;
            // 
            // cbbDevice
            // 
            this.cbbDevice.AutoResize = false;
            this.cbbDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDevice.Depth = 0;
            this.cbbDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDevice.DropDownHeight = 174;
            this.cbbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDevice.DropDownWidth = 121;
            this.cbbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDevice.FormattingEnabled = true;
            this.cbbDevice.IntegralHeight = false;
            this.cbbDevice.ItemHeight = 43;
            this.cbbDevice.Location = new System.Drawing.Point(190, 101);
            this.cbbDevice.MaxDropDownItems = 4;
            this.cbbDevice.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDevice.Name = "cbbDevice";
            this.cbbDevice.Size = new System.Drawing.Size(310, 49);
            this.cbbDevice.StartIndex = 0;
            this.cbbDevice.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device Name";
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(190, 17);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(310, 50);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(119, 42);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(28, 25);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // DetailForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailForms";
            this.Text = "DetailForms";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton exitbutton;
        private MaterialSkin.Controls.MaterialButton buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.Label Id;
        private MaterialSkin.Controls.MaterialComboBox cbbDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker BorrowDay;
        private MaterialSkin.Controls.MaterialComboBox cbbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker actualReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker returnDay;
    }
}
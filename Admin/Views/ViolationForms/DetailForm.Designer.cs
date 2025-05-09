namespace Admin.Views.ViolationForms
{
    partial class DetailForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new MaterialSkin.Controls.MaterialSwitch();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbType = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbReservation = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbBorrow = new MaterialSkin.Controls.MaterialComboBox();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDevice = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.Id = new System.Windows.Forms.Label();
            this.cbbDescription = new MaterialSkin.Controls.MaterialComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitbutton);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(12, 709);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 68);
            this.panel2.TabIndex = 7;
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
            this.panel1.Controls.Add(this.cbbDescription);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.cbbReservation);
            this.panel1.Controls.Add(this.cbbBorrow);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtDevice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 692);
            this.panel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fine Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Description";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Depth = 0;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(190, 650);
            this.status.Margin = new System.Windows.Forms.Padding(0);
            this.status.MouseLocation = new System.Drawing.Point(-1, -1);
            this.status.MouseState = MaterialSkin.MouseState.HOVER;
            this.status.Name = "status";
            this.status.Ripple = true;
            this.status.Size = new System.Drawing.Size(140, 37);
            this.status.TabIndex = 27;
            this.status.Text = "Thanh toán";
            this.status.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.AnimateReadOnly = false;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(190, 579);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(310, 50);
            this.txtAmount.TabIndex = 26;
            this.txtAmount.Text = "";
            this.txtAmount.TrailingIcon = null;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 524);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 40);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // cbbType
            // 
            this.cbbType.AutoResize = false;
            this.cbbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbType.Depth = 0;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbType.DropDownHeight = 174;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownWidth = 121;
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.IntegralHeight = false;
            this.cbbType.ItemHeight = 43;
            this.cbbType.Items.AddRange(new object[] {
            "Late_return",
            "Damaged",
            "Lost",
            "No_show"});
            this.cbbType.Location = new System.Drawing.Point(190, 372);
            this.cbbType.MaxDropDownItems = 4;
            this.cbbType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(310, 49);
            this.cbbType.StartIndex = 0;
            this.cbbType.TabIndex = 23;
            // 
            // cbbReservation
            // 
            this.cbbReservation.AutoResize = false;
            this.cbbReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbReservation.Depth = 0;
            this.cbbReservation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbReservation.DropDownHeight = 174;
            this.cbbReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReservation.DropDownWidth = 121;
            this.cbbReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbReservation.FormattingEnabled = true;
            this.cbbReservation.IntegralHeight = false;
            this.cbbReservation.ItemHeight = 43;
            this.cbbReservation.Location = new System.Drawing.Point(190, 301);
            this.cbbReservation.MaxDropDownItems = 4;
            this.cbbReservation.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbReservation.Name = "cbbReservation";
            this.cbbReservation.Size = new System.Drawing.Size(310, 49);
            this.cbbReservation.StartIndex = 0;
            this.cbbReservation.TabIndex = 22;
            // 
            // cbbBorrow
            // 
            this.cbbBorrow.AutoResize = false;
            this.cbbBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbBorrow.Depth = 0;
            this.cbbBorrow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbBorrow.DropDownHeight = 174;
            this.cbbBorrow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBorrow.DropDownWidth = 121;
            this.cbbBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbBorrow.FormattingEnabled = true;
            this.cbbBorrow.IntegralHeight = false;
            this.cbbBorrow.ItemHeight = 43;
            this.cbbBorrow.Location = new System.Drawing.Point(190, 231);
            this.cbbBorrow.MaxDropDownItems = 4;
            this.cbbBorrow.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbBorrow.Name = "cbbBorrow";
            this.cbbBorrow.Size = new System.Drawing.Size(310, 49);
            this.cbbBorrow.StartIndex = 0;
            this.cbbBorrow.TabIndex = 21;
            this.cbbBorrow.SelectedIndexChanged += new System.EventHandler(this.cbbBorrow_SelectedIndexChanged);
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Depth = 0;
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(190, 154);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(310, 50);
            this.txtUser.TabIndex = 20;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            // 
            // txtDevice
            // 
            this.txtDevice.AnimateReadOnly = false;
            this.txtDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevice.Depth = 0;
            this.txtDevice.Enabled = false;
            this.txtDevice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDevice.LeadingIcon = null;
            this.txtDevice.Location = new System.Drawing.Point(190, 87);
            this.txtDevice.MaxLength = 50;
            this.txtDevice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDevice.Multiline = false;
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.ReadOnly = true;
            this.txtDevice.Size = new System.Drawing.Size(310, 50);
            this.txtDevice.TabIndex = 19;
            this.txtDevice.Text = "";
            this.txtDevice.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Violation Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reservations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Borrow ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 112);
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
            // cbbDescription
            // 
            this.cbbDescription.AutoResize = false;
            this.cbbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDescription.Depth = 0;
            this.cbbDescription.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDescription.DropDownHeight = 174;
            this.cbbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDescription.DropDownWidth = 121;
            this.cbbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDescription.FormattingEnabled = true;
            this.cbbDescription.IntegralHeight = false;
            this.cbbDescription.ItemHeight = 43;
            this.cbbDescription.Items.AddRange(new object[] {
            "Khóa thẻ 1 tháng",
            "Khóa thẻ 2 tháng",
            "Bồi thường",
            "Khóa thẻ 1 tháng và bồi thường"});
            this.cbbDescription.Location = new System.Drawing.Point(190, 446);
            this.cbbDescription.MaxDropDownItems = 4;
            this.cbbDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDescription.Name = "cbbDescription";
            this.cbbDescription.Size = new System.Drawing.Size(310, 49);
            this.cbbDescription.StartIndex = 0;
            this.cbbDescription.TabIndex = 31;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.Label Id;
        private MaterialSkin.Controls.MaterialComboBox cbbBorrow;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialTextBox txtDevice;
        private MaterialSkin.Controls.MaterialSwitch status;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox cbbType;
        private MaterialSkin.Controls.MaterialComboBox cbbReservation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cbbDescription;
    }
}
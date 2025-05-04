namespace Admin.Views.CategoryForms
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
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new MaterialSkin.Controls.MaterialTextBox();
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
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(12, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 68);
            this.panel2.TabIndex = 3;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(27, 15);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(69, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Thoát";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
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
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 590);
            this.panel1.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(190, 264);
            this.txtQuantity.MaxLength = 50;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(310, 50);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.Text = "";
            this.txtQuantity.TrailingIcon = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(190, 100);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 50);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // txtNote
            // 
            this.txtNote.AnimateReadOnly = false;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Depth = 0;
            this.txtNote.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNote.LeadingIcon = null;
            this.txtNote.Location = new System.Drawing.Point(190, 173);
            this.txtNote.MaxLength = 50;
            this.txtNote.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNote.Multiline = false;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(310, 50);
            this.txtNote.TabIndex = 6;
            this.txtNote.Text = "";
            this.txtNote.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note";
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
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 678);
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
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.Label Id;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtName;
    }
}
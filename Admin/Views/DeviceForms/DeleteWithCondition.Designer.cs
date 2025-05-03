namespace Admin.Views.DeviceForms
{
    partial class DeleteWithCondition
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
            this.txtCode = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdelete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AnimateReadOnly = false;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Depth = 0;
            this.txtCode.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.LeadingIcon = null;
            this.txtCode.Location = new System.Drawing.Point(80, 94);
            this.txtCode.MaxLength = 50;
            this.txtCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(348, 50);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thiết bị cần xóa";
            // 
            // btdelete
            // 
            this.btdelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btdelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btdelete.Depth = 0;
            this.btdelete.HighEmphasis = true;
            this.btdelete.Icon = null;
            this.btdelete.Location = new System.Drawing.Point(175, 198);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btdelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btdelete.Name = "btdelete";
            this.btdelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btdelete.Size = new System.Drawing.Size(158, 36);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "Xóa Theo Điều kiện";
            this.btdelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btdelete.UseAccentColor = false;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // DeleteWithCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 293);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Name = "DeleteWithCondition";
            this.Text = "DeleteWithCondition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtCode;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btdelete;
    }
}
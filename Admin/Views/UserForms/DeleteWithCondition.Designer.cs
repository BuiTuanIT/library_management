namespace Admin.Views.UserForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.active = new MaterialSkin.Controls.MaterialSwitch();
            this.delete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last checkin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active";
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(17, 74);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(231, 22);
            this.checkin.TabIndex = 3;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Depth = 0;
            this.active.Location = new System.Drawing.Point(190, 140);
            this.active.Margin = new System.Windows.Forms.Padding(0);
            this.active.MouseLocation = new System.Drawing.Point(-1, -1);
            this.active.MouseState = MaterialSkin.MouseState.HOVER;
            this.active.Name = "active";
            this.active.Ripple = true;
            this.active.Size = new System.Drawing.Size(58, 37);
            this.active.TabIndex = 4;
            this.active.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delete.Depth = 0;
            this.delete.HighEmphasis = true;
            this.delete.Icon = null;
            this.delete.Location = new System.Drawing.Point(60, 207);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete.Name = "delete";
            this.delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delete.Size = new System.Drawing.Size(150, 36);
            this.delete.TabIndex = 5;
            this.delete.Text = "Xóa với điều kiện";
            this.delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete.UseAccentColor = false;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DeleteWithCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 274);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.active);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWithCondition";
            this.Text = "DeleteWithCondition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker checkin;
        private MaterialSkin.Controls.MaterialSwitch active;
        private MaterialSkin.Controls.MaterialButton delete;
    }
}
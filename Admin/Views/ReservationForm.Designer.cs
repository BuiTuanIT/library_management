namespace Admin.Views
{
    partial class ReservationForm
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
            this.ListReservation = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reload = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListReservation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListReservation);
            this.panel2.Location = new System.Drawing.Point(5, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 678);
            this.panel2.TabIndex = 5;
            // 
            // ListReservation
            // 
            this.ListReservation.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.ListReservation.Location = new System.Drawing.Point(3, 2);
            this.ListReservation.Name = "ListReservation";
            this.ListReservation.RowHeadersVisible = false;
            this.ListReservation.RowHeadersWidth = 51;
            this.ListReservation.RowTemplate.Height = 24;
            this.ListReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListReservation.Size = new System.Drawing.Size(1007, 675);
            this.ListReservation.TabIndex = 1;
            this.ListReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListReservation_CellContentClick);
            this.ListReservation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListReservation_CellDoubleClick);
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
            this.panel1.Controls.Add(this.Reload);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 86);
            this.panel1.TabIndex = 4;
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.DarkViolet;
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Location = new System.Drawing.Point(384, 10);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(144, 59);
            this.Reload.TabIndex = 3;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkViolet;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(197, 10);
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
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListReservation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ListReservation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}
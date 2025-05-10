namespace Admin.Views
{
    partial class Thongkecheckin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCheckin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWeek = new MaterialSkin.Controls.MaterialComboBox();
            this.lblWeekRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCheckin)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCheckin
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCheckin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCheckin.Legends.Add(legend1);
            this.chartCheckin.Location = new System.Drawing.Point(12, 167);
            this.chartCheckin.Name = "chartCheckin";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCheckin.Series.Add(series1);
            this.chartCheckin.Size = new System.Drawing.Size(998, 614);
            this.chartCheckin.TabIndex = 0;
            this.chartCheckin.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ SINH VIÊN CHECKIN TRONG TUẦN ";
            // 
            // cbbWeek
            // 
            this.cbbWeek.AutoResize = false;
            this.cbbWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbWeek.Depth = 0;
            this.cbbWeek.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbWeek.DropDownHeight = 174;
            this.cbbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWeek.DropDownWidth = 121;
            this.cbbWeek.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbWeek.FormattingEnabled = true;
            this.cbbWeek.IntegralHeight = false;
            this.cbbWeek.ItemHeight = 43;
            this.cbbWeek.Location = new System.Drawing.Point(56, 89);
            this.cbbWeek.MaxDropDownItems = 4;
            this.cbbWeek.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbWeek.Name = "cbbWeek";
            this.cbbWeek.Size = new System.Drawing.Size(295, 49);
            this.cbbWeek.StartIndex = 0;
            this.cbbWeek.TabIndex = 2;
            this.cbbWeek.SelectedIndexChanged += new System.EventHandler(this.CbbWeek_SelectedIndexChanged);
            // 
            // lblWeekRange
            // 
            this.lblWeekRange.AutoSize = true;
            this.lblWeekRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekRange.Location = new System.Drawing.Point(549, 104);
            this.lblWeekRange.Name = "lblWeekRange";
            this.lblWeekRange.Size = new System.Drawing.Size(0, 29);
            this.lblWeekRange.TabIndex = 3;
            // 
            // Thongkecheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 793);
            this.Controls.Add(this.lblWeekRange);
            this.Controls.Add(this.cbbWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCheckin);
            this.Name = "Thongkecheckin";
            this.Text = "Thongkecheckin";
            ((System.ComponentModel.ISupportInitialize)(this.chartCheckin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCheckin;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbbWeek;
        private System.Windows.Forms.Label lblWeekRange;
    }
}
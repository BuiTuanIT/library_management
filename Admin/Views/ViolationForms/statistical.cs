using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Admin.Controller;

namespace Admin.Views.ViolationForms
{
    public partial class statistical : Form
    {
        private ViolationController violationController;

        public statistical()
        {
            InitializeComponent();
            violationController = new ViolationController();
            InitializeChart();
            LoadViolationData();
        }

        private void InitializeChart()
        {
            try
            {
                // Xóa dữ liệu cũ
                chartViolations.Series.Clear();
                chartViolations.Titles.Clear();
                chartViolations.Legends.Clear();
                chartViolations.ChartAreas.Clear();

                // Thêm ChartArea
                ChartArea chartArea = new ChartArea();
                chartArea.BackColor = Color.White;
                chartArea.BorderColor = Color.White;
                chartArea.BorderWidth = 0;
                chartViolations.ChartAreas.Add(chartArea);

                // Thêm tiêu đề
                Title title = new Title();
                title.Text = "Thống kê vi phạm theo trạng thái xử lý";
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                chartViolations.Titles.Add(title);

                // Thêm series cho biểu đồ tròn
                Series series = new Series("Vi phạm");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "{0}\n{1} vi phạm";
                series.LegendText = "#VALX (#VALY)";
                series["PieLabelStyle"] = "Outside";
                series["DoughnutRadius"] = "60";
                series.Palette = ChartColorPalette.BrightPastel;
                series.BorderWidth = 1;
                series.BorderColor = Color.White;
                chartViolations.Series.Add(series);

                // Thêm legend
                Legend legend = new Legend();
                legend.Docking = Docking.Bottom;
                legend.Alignment = StringAlignment.Center;
                legend.BackColor = Color.White;
                chartViolations.Legends.Add(legend);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statistical_Load(object sender, EventArgs e)
        {
            LoadViolationData();
        }

        private void LoadViolationData()
        {
            try
            {
                DataTable dt = violationController.GetViolationStatistics();
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Xóa dữ liệu cũ
                    chartViolations.Series[0].Points.Clear();

                    decimal totalFines = 0;

                    // Thêm dữ liệu mới
                    foreach (DataRow row in dt.Rows)
                    {
                        string status = row["status"].ToString();
                        int count = Convert.ToInt32(row["total_violations"]);
                        decimal fines = Convert.ToDecimal(row["total_fines"]);

                        // Thêm điểm dữ liệu vào biểu đồ
                        DataPoint point = new DataPoint();
                        point.SetValueXY(status, count);
                        point.Label = $"{status}\n{count} vi phạm";
                        point.LegendText = $"{status} ({count})";
                        point.Font = new Font("Arial", 10);
                        chartViolations.Series[0].Points.Add(point);

                        // Cộng dồn tiền phạt
                        totalFines += fines;
                    }

                    // Hiển thị tổng tiền phạt
                    lblTotalFines.Text = totalFines.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu vi phạm để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

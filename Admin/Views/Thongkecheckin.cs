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

namespace Admin.Views
{
    public partial class Thongkecheckin: Form
    {
        private CheckinController checkinController;

        public Thongkecheckin()
        {
            InitializeComponent();
            checkinController = new CheckinController();
            Thongkecheckin_Load(null, null);
        }

        private void Thongkecheckin_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            // Tính số tuần trong năm
            int totalWeeks = GetWeeksInYear(currentYear);

            // Thêm tuần vào ComboBox
            for (int i = 1; i <= totalWeeks; i++)
            {
                cbbWeek.Items.Add("Tuần " + i);
            }

            // Mặc định chọn tuần hiện tại
            int currentWeek = GetWeekOfYear(DateTime.Now);
            cbbWeek.SelectedIndex = currentWeek - 1;

            // Cấu hình biểu đồ
            ConfigureChart();

            // Bắt sự kiện chọn tuần
            cbbWeek.SelectedIndexChanged += CbbWeek_SelectedIndexChanged;

            // Gọi thủ công để hiển thị tuần hiện tại
            CbbWeek_SelectedIndexChanged(null, null);
        }

        private void ConfigureChart()
        {
            // Cấu hình trục X
            chartCheckin.ChartAreas[0].AxisX.Title = "Ngày";
            chartCheckin.ChartAreas[0].AxisX.Interval = 1;
            chartCheckin.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

            // Cấu hình trục Y
            chartCheckin.ChartAreas[0].AxisY.Title = "Số lượng check-in";
            chartCheckin.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // Cấu hình style
            chartCheckin.ChartAreas[0].BackColor = Color.White;
            chartCheckin.BackColor = Color.White;

            // Cấu hình series
            chartCheckin.Series[0].Name = "Check-in";
            chartCheckin.Series[0].ChartType = SeriesChartType.Column;
        }

        private void CbbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWeek.SelectedIndex >= 0)
            {
                int selectedWeek = cbbWeek.SelectedIndex + 1;
                int year = DateTime.Now.Year;

                DateTime startOfWeek = FirstDateOfWeekISO8601(year, selectedWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                lblWeekRange.Text = $"Tuần {selectedWeek}: {startOfWeek:dd/MM/yyyy} - {endOfWeek:dd/MM/yyyy}";

                // Cập nhật dữ liệu cho biểu đồ
                UpdateChartData(startOfWeek, endOfWeek);
            }
        }

        private void UpdateChartData(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Xóa dữ liệu cũ
                chartCheckin.Series[0].Points.Clear();

                // Lấy dữ liệu từ controller
                DataTable stats = checkinController.GetWeeklyCheckinStats(startDate, endDate);

                // Thêm dữ liệu vào biểu đồ
                foreach (DataRow row in stats.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["checkin_date"]);
                    int count = Convert.ToInt32(row["total_checkins"]);
                    chartCheckin.Series[0].Points.AddXY(date.ToString("dd/MM"), count);
                }

                // Cập nhật tiêu đề biểu đồ
                chartCheckin.Titles.Clear();
                chartCheckin.Titles.Add(new Title($"Thống kê check-in từ {startDate:dd/MM/yyyy} đến {endDate:dd/MM/yyyy}"));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lấy số tuần trong năm (ISO 8601)
        private int GetWeeksInYear(int year)
        {
            DateTime dec28 = new DateTime(year, 12, 28);
            return GetWeekOfYear(dec28);
        }

        // Lấy số tuần của một ngày (ISO 8601: tuần bắt đầu từ thứ Hai)
        private int GetWeekOfYear(DateTime date)
        {
            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
            return cul.Calendar.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        // Lấy ngày đầu của tuần (theo ISO 8601)
        private DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan4 = new DateTime(year, 1, 4);
            int daysOffset = DayOfWeek.Monday - jan4.DayOfWeek;
            DateTime firstMonday = jan4.AddDays(daysOffset);

            return firstMonday.AddDays((weekOfYear - 1) * 7);
        }
    }
}

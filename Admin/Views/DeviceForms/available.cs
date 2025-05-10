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

namespace Admin.Views.DeviceForms
{
    public partial class available : Form
    {
        private DeviceController deviceController;

        public available()
        {
            InitializeComponent();
            deviceController = new DeviceController();
            ConfigureChart();
            LoadData();
        }

        private void ConfigureChart()
        {
            // Cấu hình biểu đồ
            deviceVailable.ChartAreas[0].AxisX.Title = "Tên thiết bị";
            deviceVailable.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            deviceVailable.ChartAreas[0].AxisX.Interval = 1;
            deviceVailable.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;

            deviceVailable.ChartAreas[0].AxisY.Title = "Số lượng đang mượn";
            deviceVailable.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            deviceVailable.ChartAreas[0].BackColor = Color.White;
            deviceVailable.BackColor = Color.White;

            // Cấu hình series
            deviceVailable.Series[0].Name = "Thiết bị đang mượn";
            deviceVailable.Series[0].ChartType = SeriesChartType.Column;
        }

        private void LoadData()
        {
            try
            {
                // Cập nhật biểu đồ thống kê theo thiết bị
                DataTable deviceStats = deviceController.GetCurrentlyBorrowedDevices();
                deviceVailable.Series[0].Points.Clear();
                foreach (DataRow row in deviceStats.Rows)
                {
                    string deviceName = row["devicename"].ToString();
                    int count = Convert.ToInt32(row["total_borrowed"]);
                    deviceVailable.Series[0].Points.AddXY(deviceName, count);
                }
                deviceVailable.Titles.Clear();
                deviceVailable.Titles.Add(new Title("Thống kê thiết bị đang được mượn"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

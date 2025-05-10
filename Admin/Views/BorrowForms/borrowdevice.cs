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

namespace Admin.Views.BorrowForms
{
    public partial class borrowdevice : Form
    {
        private BorrowController borrowController;

        public borrowdevice()
        {
            InitializeComponent();
            borrowController = new BorrowController();
            
            // Khởi tạo giá trị mặc định cho DateTimePicker
            dtpStartDate.Value = DateTime.Today.AddDays(-7); // 7 ngày trước
            dtpEndDate.Value = DateTime.Today; // Hôm nay
            
            InitializeChart();
            LoadData();
        }

        private void InitializeChart()
        {
            try
            {
                // Cấu hình biểu đồ
                chartBorrows.ChartAreas[0].AxisX.Title = "Ngày mượn";
                chartBorrows.ChartAreas[0].AxisY.Title = "Số lượng";
                chartBorrows.ChartAreas[0].AxisX.Interval = 1;
                chartBorrows.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                chartBorrows.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                chartBorrows.ChartAreas[0].BackColor = System.Drawing.Color.White;
                chartBorrows.Series[0].ChartType = SeriesChartType.Column;
                chartBorrows.Series[0].Color = System.Drawing.Color.SteelBlue;
                
                // Thêm tiêu đề cho biểu đồ
                chartBorrows.Titles.Add("Thống kê thiết bị đang mượn");
                chartBorrows.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Lấy dữ liệu từ controller
                DataTable borrowData = borrowController.GetBorrowedDevicesByDate(dtpStartDate.Value, dtpEndDate.Value);

                if (borrowData == null || borrowData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Cập nhật biểu đồ
                chartBorrows.Series[0].Points.Clear();
                foreach (DataRow row in borrowData.Rows)
                {
                    DateTime borrowDate = Convert.ToDateTime(row["borrow_date"]);
                    int totalBorrows = Convert.ToInt32(row["total_borrows"]);
                    chartBorrows.Series[0].Points.AddXY(borrowDate.ToShortDateString(), totalBorrows);
                }

                // Cập nhật DataGridView
                dgvBorrowDetails.DataSource = borrowData;
                dgvBorrowDetails.Columns["borrow_date"].HeaderText = "Ngày mượn";
                dgvBorrowDetails.Columns["total_borrows"].HeaderText = "Tổng số mượn";
                dgvBorrowDetails.Columns["device_names"].HeaderText = "Danh sách thiết bị";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message + "\n\nChi tiết: " + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadData();
        }
    }
}

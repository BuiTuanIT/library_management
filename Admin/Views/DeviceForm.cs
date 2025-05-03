using Admin.Controller;
using Admin.Views.DeviceForms;
using ClosedXML.Excel;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Views
{
    public partial class DeviceForm: Form
    {
        private DeviceController deviceController = new DeviceController();
        public DeviceForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListDevice.DataSource = deviceController.GetAllDevices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void ListDevice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                int deviceId = Convert.ToInt32(ListDevice.Rows[e.RowIndex].Cells["Device_Id"].Value);
                DetailForm detailForm = new DetailForm(deviceId);
                detailForm.ShowDialog();
                RefreshData();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in ListDevice.SelectedRows)
            {
                bool isSelected = false;
                if (row.Cells["chk"].Value != null)
                {
                    isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                }

                if (isSelected)
                {
                    rowsToDelete.Add(row);
                }
            }
            if (rowsToDelete.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các thiết bị đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in rowsToDelete)
                    {
                        int deviceId = Convert.ToInt32(row.Cells["Device_Id"].Value);
                        deviceController.DeleteDevice(deviceId);
                    }
                    MessageBox.Show("Xóa thiết bị thành công.");
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một thiết bị để xóa.");
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog.Title = "Chọn file Excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<Device> devices = ImportDeviceFromExcel(filePath);
                foreach (var device in devices)
                {
                    deviceController.AddDevice(device);
                }
                MessageBox.Show("Nhập dữ liệu từ Excel thành công.");
                RefreshData();
            }

        }

        private List<Device> ImportDeviceFromExcel(string filePath)
        {
            List<Device> devices = new List<Device>();
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // sheet đầu tiên
                var rows = worksheet.RangeUsed().RowsUsed();
                int hehe = 0;

                bool isFirst = true;
                foreach (var row in rows)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        continue; // Bỏ qua hàng tiêu đề
                    }
                    var device = new Device()
                    {
                        Category_Id = row.Cell(1).GetValue<int>(), // Lấy giá trị từ cột Category_Id
                        Device_Code = row.Cell(2).GetValue<string>(),
                        Status = row.Cell(3).GetValue<string>(),
                        Is_Borrowed = int.TryParse(row.Cell(4).Value.ToString(), out var isBorrowed) ? isBorrowed : 0
                    };
                    devices.Add(device);

                }
            }
            return devices;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteWithCondition deleteWithCondition = new DeleteWithCondition();
            deleteWithCondition.ShowDialog();
            RefreshData();
        }        
    }
}

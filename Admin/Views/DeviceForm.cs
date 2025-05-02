using Admin.Controller;
using Admin.Views.DeviceForms;
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
                // DetailForm detailForm = new DetailForm(deviceId);
                RefreshData();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
            RefreshData();
        }
    }
}

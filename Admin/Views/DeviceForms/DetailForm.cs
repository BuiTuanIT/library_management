using Admin.Controller;
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

namespace Admin.Views.DeviceForms
{
    public partial class DetailForm: Form
    {
        private int IdDevice;
        private DeviceController deviceController = new DeviceController();
        private CategoryDeviceController categoryDeviceController = new CategoryDeviceController();

        public DetailForm(int deviceId)
        {
            InitializeComponent();
            IdDevice = deviceId;
            LoadDeviceDetails();
        }
        public DetailForm()
        {
            InitializeComponent();
            LoadDeviceDetails();
            cbbStatus.SelectedIndexChanged += CbbStatus_SelectedIndexChanged;
        }

        private void LoadDeviceDetails()
        {
            var categories = categoryDeviceController.GetAllCategories();

            // Gán vào combobox
            cbbName.DataSource = categories;
            cbbName.DisplayMember = "Name";
            cbbName.ValueMember = "Id";

            // Nếu là form sửa (có IdDevice)
            if (IdDevice > 0)
            {
                Device device = deviceController.GetDeviceById(IdDevice);
                if (device != null)
                {
                    // Set lại giá trị được chọn
                    cbbName.SelectedValue = device.Category_Id;

                    // Gán các field còn lại
                    txtID.Text = device.Device_Id.ToString();
                    txtCode.Text = device.Device_Code;
                    cbbStatus.SelectedItem = device.Status;
                    borrow.Checked = device.Status.ToLower() != "available";
                }
            }
            else
            {
                // Nếu là form thêm mới, set giá trị mặc định
                cbbName.SelectedIndex = 0;
                cbbStatus.SelectedIndex = 0;
                borrow.Checked = cbbStatus.Text.ToLower() != "available";
            }
        }

        private void CbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            borrow.Checked = cbbStatus.Text.ToLower() != "available";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                Device device = new Device
                {
                    Device_Code = txtCode.Text,
                    Status = cbbStatus.Text,
                    Category_Id = Convert.ToInt32(cbbName.SelectedValue),
                    Is_Borrowed = cbbStatus.Text.ToLower() == "available" ? 0 : 1
                };
                if (deviceController.AddDevice(device))
                {
                    MessageBox.Show("Thêm thiết bị thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm thiết bị thất bại.");
                }
            }
            else
            {
                Device device = new Device
                {
                    Device_Id = Convert.ToInt32(txtID.Text),
                    Device_Code = txtCode.Text,
                    Status = cbbStatus.Text,
                    Category_Id = Convert.ToInt32(cbbName.SelectedValue),
                    Is_Borrowed = cbbStatus.Text.ToLower() == "available" ? 0 : 1
                };
                if (deviceController.UpdateDevice(device))
                {
                    MessageBox.Show("Cập nhật thiết bị thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật thiết bị thất bại.");
                }
            }
            Close();
        }
    }
}

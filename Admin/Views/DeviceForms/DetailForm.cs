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
                    if (device.Is_Borrowed == 1)
                    {
                        borrow.Checked = true;
                    }
                    else
                    {
                        borrow.Checked = false;
                    }
                }
            }
            else
            {
                // Nếu là form thêm mới, set giá trị mặc định
                cbbName.SelectedIndex = 0;
                cbbStatus.SelectedIndex = 0;
                borrow.Checked = false;
            }
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
                    Is_Borrowed = borrow.Checked ? 1 : 0
                };
                if (deviceController.AddDevice(device))
                {
                    MessageBox.Show("Device added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add device.");
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
                    Is_Borrowed = borrow.Checked ? 1 : 0
                };
                if (deviceController.UpdateDevice(device))
                {
                    MessageBox.Show("Device updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update device.");
                }
            }
            Close();
        }
    }
}

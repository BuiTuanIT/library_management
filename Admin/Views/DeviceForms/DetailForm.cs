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
        }

        private void LoadDeviceDetails()
        {
            Device device = deviceController.GetDeviceById(IdDevice);
            if (device != null)
            {
                cbbName.DataSource = categoryDeviceController.GetAllCategories();
                cbbName.DisplayMember = "Name";
                cbbName.ValueMember = "Id";

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
                    Category_Id = Convert.ToInt32(cbbName.SelectedItem),
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
                    Category_Id = Convert.ToInt32(cbbName.SelectedItem),
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

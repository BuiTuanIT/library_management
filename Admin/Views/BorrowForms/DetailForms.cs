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

namespace Admin.Views.BorrowForms
{
    public partial class DetailForms : Form
    {
        int idborrow;
        private BorrowController borrowController = new BorrowController();
        private DeviceController deviceController = new DeviceController();
        private UserController userController = new UserController();

        public DetailForms()
        {
            InitializeComponent();
            LoadBorrowRecord();
        }

        public DetailForms(int id)
        {
            InitializeComponent();
            idborrow = id;
            LoadBorrowRecord();
        }
        private void LoadBorrowRecord()
        {
            var devices = deviceController.GetDeviceNotBorrow();
            var users = userController.GetAllUsers();

            // Gán vào combobox
            cbbDevice.DataSource = devices;
            cbbDevice.DisplayMember = "Device_Code";
            cbbDevice.ValueMember = "Device_Id";

            cbbUser.DataSource = users;
            cbbUser.DisplayMember = "UserName";
            cbbUser.ValueMember = "UserId";


            if (idborrow > 0) 
            {
                Borrowrecords borrowrecords = borrowController.GetBorrowById(idborrow);
                if (borrowrecords != null)
                {
                    // Set lại giá trị được chọn
                    cbbDevice.SelectedValue = borrowrecords.DeviceId;
                    cbbUser.SelectedValue = borrowrecords.UsertId;
                    // Gán các field còn lại
                    txtID.Text = borrowrecords.Id.ToString();
                    BorrowDay.Value = borrowrecords.Borrow_date;
                    returnDay.Value = borrowrecords.Return_date;
                    actualReturn.Value = borrowrecords.Actual_return_date;
                }
                else
                {
                    cbbDevice.SelectedIndex = 0;
                    cbbUser.SelectedIndex = 0;
                    BorrowDay.Value = DateTime.Now;
                    returnDay.Value = DateTime.Now;
                    actualReturn.Value = DateTime.Now;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateDates())
            {
                return;
            }

            if (string.IsNullOrEmpty(txtID.Text))
            {
                // Thêm mới
                var borrowRecord = new Borrowrecords
                {
                    DeviceId = Convert.ToInt32(cbbDevice.SelectedValue),
                    UsertId = Convert.ToInt32(cbbUser.SelectedValue),
                    Borrow_date = BorrowDay.Value,
                    Return_date = returnDay.Value,
                    Actual_return_date = actualReturn.Value
                };
                if (borrowController.AddBorrow(borrowRecord))
                {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                // Cập nhật
                var borrowRecord = new Borrowrecords
                {
                    Id = Convert.ToInt32(txtID.Text),
                    DeviceId = Convert.ToInt32(cbbDevice.SelectedValue),
                    UsertId = Convert.ToInt32(cbbUser.SelectedValue),
                    Borrow_date = BorrowDay.Value,
                    Return_date = returnDay.Value,
                    Actual_return_date = actualReturn.Value
                };
                if (borrowController.UpdateBorrow(borrowRecord))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            Close();
        }

        private bool ValidateDates()
        {
            if (BorrowDay.Value >= returnDay.Value)
            {
                MessageBox.Show("Ngày mượn phải nhỏ hơn ngày trả dự kiến!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (actualReturn.Value <= BorrowDay.Value)
            {
                MessageBox.Show("Ngày trả thực tế phải lớn hơn hoặc bằng ngày mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

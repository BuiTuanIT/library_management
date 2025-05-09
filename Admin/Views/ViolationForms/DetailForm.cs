using Admin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;

namespace Admin.Views.ViolationForms
{
    public partial class DetailForm: Form
    {
        private int violationId;
        private ViolationController violationController = new ViolationController();
        private BorrowController borrowController = new BorrowController();
        private UserController userController = new UserController();
        private DeviceController deviceController = new DeviceController();
        private ReservationController reservationController = new ReservationController();

        public DetailForm()
        {
            InitializeComponent();
            LoadViolation();
        }
        public DetailForm(int Id)
        {
            InitializeComponent();
            violationId = Id;
            LoadViolation();
        }

        private void LoadViolation()
        {
            var borrow = borrowController.GetAllBorrows();

            // gán giá trị vào combobox
            cbbBorrow.DataSource = borrow;
            cbbBorrow.ValueMember = "Id";
            cbbBorrow.DisplayMember = "Id";

            if (violationId > 0)
            {
                Violation violation = violationController.GetViolationById(violationId);
                if (violation != null)
                {
                    // Set lại giá trị được chọn
                    cbbBorrow.SelectedValue = violation.borrowId;
                    // Gán các field còn lại
                    txtID.Text = violation.ViolationId.ToString();
                    txtUser.Text = violation.UserId.ToString();
                    txtDevice.Text = violation.DeviceId.ToString();
                    cbbDescription.Text = violation.ViolationDescription;
                    cbbType.Text = violation.ViolationType;
                    
                    txtAmount.Text = violation.FineAmount.ToString();

                    if (violation.ViolationStatus == "pending")
                    {
                        status.Checked = false;
                    }
                    else
                    {
                        status.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vi phạm với ID đã cho.");
                }
            }
        }

        private void cbbBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBorrow.SelectedItem != null)
            {
                Borrowrecords selectedBorrow = (Borrowrecords)cbbBorrow.SelectedItem;
                Borrowrecords borrow = borrowController.GetBorrowById(selectedBorrow.Id);
                
                if (borrow != null)
                {
                    // Get user information
                    Users user = userController.GetUsersById(borrow.UsertId);
                    if (user != null)
                    {
                        txtUser.Text = user.UserName;
                    }

                    // Get device information
                    Device device = deviceController.GetDeviceById(borrow.DeviceId);
                    if (device != null)
                    {
                        txtDevice.Text = device.Device_Code;
                    }

                    // Load confirmed reservations for this device and user
                    var reservations = reservationController.GetReservationsByDeviceAndUser(borrow.DeviceId, borrow.UsertId, "confirmed");
                    cbbReservation.DataSource = reservations;
                    cbbReservation.ValueMember = "Id";
                    cbbReservation.DisplayMember = "Id";
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbBorrow.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn thông tin mượn!");
                    return;
                }

                Borrowrecords selectedBorrow = (Borrowrecords)cbbBorrow.SelectedItem;
                decimal fineAmount = 0;
                if (!string.IsNullOrEmpty(txtAmount.Text))
                {
                    if (!decimal.TryParse(txtAmount.Text, out fineAmount))
                    {
                        MessageBox.Show("Số tiền phạt không hợp lệ!");
                        return;
                    }
                }

                // Lấy ReservationsId, nếu không có thì gán null
                int? reservationsId = null;
                if (cbbReservation.SelectedItem != null)
                {
                    Reservations selectedReservation = (Reservations)cbbReservation.SelectedItem;
                    reservationsId = selectedReservation.Id;
                }

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    // Thêm mới
                    Violation violation = new Violation()
                    {
                        UserId = selectedBorrow.UsertId,
                        DeviceId = selectedBorrow.DeviceId,
                        borrowId = selectedBorrow.Id,
                        ReservationsId = reservationsId,
                        ViolationType = cbbType.Text,
                        ViolationDescription = cbbDescription.Text,
                        ViolationDate = DateTime.Now,
                        FineAmount = fineAmount,
                        ViolationStatus = status.Checked ? "resolved" : "pending"
                    };

                    if (violationController.AddViolation(violation))
                    {
                        MessageBox.Show("Thêm vi phạm thành công.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vi phạm thất bại.");
                    }
                }
                else
                {
                    // Cập nhật
                    int violationId;
                    if (!int.TryParse(txtID.Text, out violationId))
                    {
                        MessageBox.Show("ID vi phạm không hợp lệ!");
                        return;
                    }

                    Violation violation = new Violation()
                    {
                        ViolationId = violationId,
                        UserId = selectedBorrow.UsertId,
                        DeviceId = selectedBorrow.DeviceId,
                        borrowId = selectedBorrow.Id,
                        ReservationsId = reservationsId,
                        ViolationType = cbbType.Text,
                        ViolationDescription = cbbDescription.Text,
                        ViolationDate = dateTimePicker1.Value,
                        FineAmount = fineAmount,
                        ViolationStatus = status.Checked ? "resolved" : "pending"
                    };

                    if (violationController.UpdateViolation(violation))
                    {
                        MessageBox.Show("Cập nhật vi phạm thành công.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật vi phạm thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

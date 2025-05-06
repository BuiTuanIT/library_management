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

namespace Admin.Views.ReservationForms
{
    public partial class DetailForm : Form
    {
        int idReservation;
        private ReservationController reservationController = new ReservationController();
        private DeviceController deviceController = new DeviceController();
        private UserController userController = new UserController();

        public DetailForm()
        {
            InitializeComponent();
            LoadReservationDetails();
        }
        public DetailForm(int reservationId)
        {
            InitializeComponent();
            idReservation = reservationId;
            LoadReservationDetails();
        }
        private void LoadReservationDetails()
        {
            var devices = deviceController.GetAllDevices();
            var users = userController.GetAllUsers();
            // Gán vào combobox
            cbbDevice.DataSource = devices;
            cbbDevice.DisplayMember = "Device_Code";
            cbbDevice.ValueMember = "Device_Id";

            cbbUser.DataSource = users;
            cbbUser.DisplayMember = "UserName";
            cbbUser.ValueMember = "UserId";

            if (idReservation > 0)
            {
                Reservations reservation = reservationController.GetReservationsById(idReservation).FirstOrDefault();
                if (reservation != null)
                {
                    // Set lại giá trị được chọn
                    cbbDevice.SelectedValue = reservation.Device_Id;
                    cbbUser.SelectedValue = reservation.User_Id;
                    // Gán các field còn lại
                    txtID.Text = reservation.Id.ToString();
                    daystart.Value = reservation.Start_Date;
                    dayend.Value = reservation.End_Date;
                    cbbStatus.SelectedItem = reservation.Status;
                }
            }
            else
            {
                // Nếu là form thêm mới thì gán giá trị mặc định
                cbbDevice.SelectedIndex = 0;
                cbbUser.SelectedIndex = 0;
                daystart.Value = DateTime.Now;
                dayend.Value = DateTime.Now.AddDays(1);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                Reservations reservation = new Reservations()
                {
                    Device_Id = Convert.ToInt32(cbbDevice.SelectedValue),
                    User_Id = Convert.ToInt32(cbbUser.SelectedValue),
                    Start_Date = daystart.Value,
                    End_Date = dayend.Value,
                    Status = cbbStatus.Text
                };
                if (reservationController.AddReservation(reservation))
                {
                    MessageBox.Show("Thêm thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                Reservations reservation = new Reservations()
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Device_Id = Convert.ToInt32(cbbDevice.SelectedValue),
                    User_Id = Convert.ToInt32(cbbUser.SelectedValue),
                    Start_Date = daystart.Value,
                    End_Date = dayend.Value,
                    Status = cbbStatus.Text
                };
                if (reservationController.UpdateReservation(reservation))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            Close();
        }
    }
}

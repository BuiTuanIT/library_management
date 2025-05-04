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

namespace Admin.Views
{
    public partial class ReservationForm: Form
    {
        private ReservationController reservationController = new ReservationController();
        public ReservationForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListReservation.DataSource = reservationController.GetAllReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}

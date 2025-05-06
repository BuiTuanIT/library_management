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
using Admin.Views.ReservationForms;

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
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
            RefreshData();
        }

        private void ListReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                // Lấy reservation_id từ dòng được chọn
                int reservationId = Convert.ToInt32(ListReservation.Rows[e.RowIndex].Cells["Id"].Value);
                
                // Mở form chi tiết
                DetailForm detailForm = new DetailForm(reservationId);
                detailForm.ShowDialog();
                
                // Refresh lại dữ liệu sau khi đóng form
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở chi tiết đặt chỗ: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsToDelete = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in ListReservation.SelectedRows)
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
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa các đặt chỗ đã chọn không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in rowsToDelete)
                        {
                            int reservationId = Convert.ToInt32(row.Cells["Reservation_Id"].Value);
                            reservationController.DeleteReservation(reservationId);
                        }
                        MessageBox.Show("Xóa đặt chỗ thành công.");
                        RefreshData();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một đặt chỗ để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đặt chỗ: " + ex.Message);
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

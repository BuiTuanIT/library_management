using Admin.Controller;
using Admin.Views.ViolationForms;
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
    public partial class ViolationForm: Form
    {
        private ViolationController violationController = new ViolationController();
        public ViolationForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListViolation.DataSource = violationController.GetViolations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void ViolationForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
            RefreshData();

        }

        private void ListViolation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int violationId = Convert.ToInt32(ListViolation.Rows[e.RowIndex].Cells["ViolationId"].Value);
                DetailForm detailForm = new DetailForm(violationId);
                detailForm.ShowDialog();
                RefreshData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in ListViolation.Rows)
            {
                bool isSelected = false;

                if (row.Cells["chk"].Value != null)
                {
                    isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                }

                if (isSelected)
                {
                    // Kiểm tra trạng thái thanh toán
                    string status = row.Cells["ViolationStatus"].Value?.ToString();
                    if (status == "pending")
                    {
                        MessageBox.Show("Không thể xóa vi phạm chưa thanh toán. Vui lòng thanh toán trước khi xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    rowsToDelete.Add(row);
                }
            }

            if(rowsToDelete.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các vi phạm đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in rowsToDelete)
                    {
                        int violationId = Convert.ToInt32(row.Cells["ViolationId"].Value);
                        violationController.DeleteViolation(violationId);
                    }
                    MessageBox.Show("Xóa vi phạm thành công.");
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa vi phạm: " + ex.Message);
                }
            }
        }

        private void statistical_Click(object sender, EventArgs e)
        {
            statistical statisticalForm = new statistical();
            statisticalForm.ShowDialog();
        }
    }
}

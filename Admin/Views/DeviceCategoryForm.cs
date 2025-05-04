using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Controller;
using Admin.Views.CategoryForms;
namespace Admin.Views
{
    public partial class DeviceCategoryForm: Form
    {
        private CategoryDeviceController categoryDeviceController = new CategoryDeviceController();

        public DeviceCategoryForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void DeviceCategoryForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            try
            {
                ListDeviceCategory.DataSource = categoryDeviceController.GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.ShowDialog();
            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowsToDelete = new List<DataGridViewRow>();

            // Duyệt tất cả dòng
            foreach (DataGridViewRow row in ListDeviceCategory.Rows)
            {
                bool isSelected = false;

                // Tránh lỗi nếu ô checkbox chưa có giá trị
                if (row.Cells["chk"].Value != null)
                {
                    isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                }

                if (isSelected)
                {
                    rowsToDelete.Add(row);
                }
            }

            if (rowsToDelete.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 danh mục để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục đã chọn không?",
                                                "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in rowsToDelete)  // <<< Duyệt danh sách đã tick
                {
                    int Id = Convert.ToInt32(row.Cells["Id"].Value);
                    categoryDeviceController.DeleteCategory(Id);
                }

                MessageBox.Show("Xóa danh mục thành công.");
                RefreshData();
            }
        }

        private void ListDeviceCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int categoryId = Convert.ToInt32(ListDeviceCategory.Rows[e.RowIndex].Cells["Id"].Value);
                DetailForm detailForm = new DetailForm(categoryId);
                detailForm.ShowDialog();
                RefreshData();
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

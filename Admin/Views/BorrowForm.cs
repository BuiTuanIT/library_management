using Admin.Controller;
using Admin.Views.BorrowForms;
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
    public partial class BorrowForm : Form
    {
        private BorrowController borrowController = new BorrowController();
        public BorrowForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListBorrow.DataSource = borrowController.GetAllBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DetailForms detailForm = new DetailForms();
            detailForm.ShowDialog();
            RefreshData();
        }

        private void ListBorrow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int borrowId = Convert.ToInt32(ListBorrow.Rows[e.RowIndex].Cells["Id"].Value);
                DetailForms detailForm = new DetailForms(borrowId);
                detailForm.ShowDialog();
                RefreshData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in ListBorrow.Rows)
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

            if(rowsToDelete.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các bản ghi mượn đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in rowsToDelete)
                    {
                        int borrowId = Convert.ToInt32(row.Cells["Id"].Value);
                        borrowController.DeleteBorrow(borrowId);
                    }
                    MessageBox.Show("Xóa bản ghi mượn thành công.");
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa bản ghi mượn: " + ex.Message);
                }
            }
        }

        private void inUse_Click(object sender, EventArgs e)
        {
            borrowdevice borrowdevice = new borrowdevice();
            borrowdevice.ShowDialog();
        }
    }
}

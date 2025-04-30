using Admin.Controller;
using Admin.Views.UserForms;
using ClosedXML.Excel;
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

namespace Admin.Views
{
    public partial class UserForm : Form
    {
        private UserController userController = new UserController();

        public UserForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                ListUser.DataSource = userController.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                int userId = Convert.ToInt32(ListUser.Rows[e.RowIndex].Cells["UserId"].Value);
                DetailForm detailForm = new DetailForm(userId);
                detailForm.ShowDialog();
                RefreshData();
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
            foreach (DataGridViewRow row in ListUser.Rows)
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
                MessageBox.Show("Vui lòng chọn ít nhất 1 user để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa user đã chọn không?",
                                                "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in rowsToDelete)  // <<< Duyệt danh sách đã tick
                {
                    int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                    userController.DeleteUser(userId);
                }

                MessageBox.Show("Xóa người dùng thành công.");
                RefreshData();
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                var users = ImportUsersFromExcel(filePath);

                
                foreach (var user in users)
                {
                    bool v = userController.AddUser(user);
                    if (v)
                    {
                        MessageBox.Show($"Đã thêm {users.Count} người dùng từ Excel!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm người dùng {user.UserName} thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                RefreshData();
            }
        }

        private List<Users> ImportUsersFromExcel(string filePath)
        {
            var users = new List<Users>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); // sheet đầu tiên
                var rows = worksheet.RangeUsed().RowsUsed();

                bool isFirst = true;
                foreach (var row in rows)
                {
                    if (isFirst)
                    {
                        isFirst = false; // bỏ dòng tiêu đề
                        continue;
                    }

                    var user = new Users
                    {
                        UserName = row.Cell(1).GetValue<string>(),
                        Password = row.Cell(2).GetValue<string>(),
                        Birthday = DateTime.TryParse(row.Cell(3).GetValue<string>(), out var birthday) ? birthday : DateTime.MinValue,
                        Sex = row.Cell(4).GetValue<string>(),
                        last_checkin = DateTime.TryParse(row.Cell(5).GetValue<string>(), out var checkin) ? checkin : DateTime.MinValue,
                        email = row.Cell(6).GetValue<string>(),
                        phone = row.Cell(7).GetValue<string>(),
                        is_active = int.TryParse(row.Cell(8).GetValue<string>(), out var active) ? active : 0
                    };

                    users.Add(user);
                }
            }

            return users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteWithCondition deleteWithCondition = new DeleteWithCondition();
            deleteWithCondition.ShowDialog();
            RefreshData();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

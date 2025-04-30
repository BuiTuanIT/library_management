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

namespace Admin.Views.UserForms
{
    public partial class DeleteWithCondition: Form
    {
        UserController userController = new UserController();
        public DeleteWithCondition()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                last_checkin = checkin.Value,
                is_active = active.Checked ? 1 : 0
            };
            bool result = userController.DeleteWithCondition(users);
            if (result)
            {
                MessageBox.Show("Xóa người dùng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa người dùng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}

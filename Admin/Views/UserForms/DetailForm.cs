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
    public partial class DetailForm: Form
    {
        private int Iduser;
        UserController userController = new UserController();
        public DetailForm(int UserId)
        {
            InitializeComponent();
            Iduser = UserId;
            LoadUserDetails();
        }
        public DetailForm()
        {
            InitializeComponent();
        }

        private void LoadUserDetails()
        {
            Users users = userController.GetUsersById(Iduser);
            if (users != null)
            {
                txtID.Text = users.UserId.ToString();
                txtName.Text = users.UserName;
                txtPassWord.Text = users.Password;
                birthday.Value = users.Birthday;
                cbbSex.SelectedItem = users.Sex;
                txtMail.Text = users.email;
                txtPhone.Text = users.phone;
                chekin.Value = users.last_checkin == null ? DateTime.Now : Convert.ToDateTime(users.last_checkin);
                txtStudentCode.Text = users.student_code;
                if (users.is_active == 1)
                {
                    active.Checked = true;
                }
                else
                {
                    active.Checked = false;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassWord.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if(cbbSex.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                    return;
                }
                Users users = new Users()
                {
                    UserName = txtName.Text,
                    Password = txtPassWord.Text,
                    Birthday = birthday.Value,
                    Sex = cbbSex.SelectedItem.ToString(),
                    email = txtMail.Text,
                    phone = txtPhone.Text,
                    last_checkin = null,
                    student_code = txtStudentCode.Text,
                    is_active = active.Checked ? 1 : 0
                };
                bool result = userController.AddUser(users);
                if (result)
                {
                    MessageBox.Show("Thêm người dùng thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại.");
                }
            }
            else
            {
                Users users = new Users()
                {
                    UserId = Convert.ToInt32(txtID.Text),
                    UserName = txtName.Text,
                    Password = txtPassWord.Text,
                    Birthday = birthday.Value,
                    Sex = cbbSex.SelectedItem.ToString(),
                    email = txtMail.Text,
                    phone = txtPhone.Text,
                    student_code = txtStudentCode.Text,
                    is_active = active.Checked ? 1 : 0
                };
                bool result = userController.UpdateUser(users);
                if (result)
                {
                    MessageBox.Show("Cập nhật người dùng thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại.");
                }
            }
            Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (MaterialSkin.Controls.MaterialTextBox)sender;

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (textBox.Text.Length + 1 > 11)
            {
                e.Handled = true;
            }
        }


        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
            e.KeyChar != '@' &&
            e.KeyChar != '.' &&
            e.KeyChar != '-' &&
            e.KeyChar != '_' &&
            e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string input = txtMail.Text.ToLower();

            // Tự động thêm "@gmail.com" khi người dùng nhập xong phần tên
            if (!input.Contains("@") && !string.IsNullOrEmpty(input))
            {
                if (input.Length > 2) // Sau khi nhập 2 ký tự trở lên
                {
                    txtMail.Text += "@gmail.com";
                    txtMail.Select(input.Length, 0); // Đặt con trỏ trước "@gmail.com"
                }
            }
            else
            {
                // Kiểm tra định dạng
                bool isValid = input.EndsWith("@gmail.com") && input.IndexOf('@') > 0;
                txtMail.BackColor = isValid ? SystemColors.Window : Color.LightPink;
            }
        }
    }
}

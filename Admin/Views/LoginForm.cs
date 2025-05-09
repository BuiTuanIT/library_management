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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
            _logged = false;
        }

        // Logged
        private bool _logged = false;
        public bool Logged
        {
            get { return _logged; }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                // Check login
                if (string.IsNullOrEmpty(txtTaikhoan.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                    return;
                }

                if (txtTaikhoan.Text.ToLower() == "admin" && txtMatkhau.Text.ToLower() == "admin")
                {
                    _logged = true;
                    this.Hide(); // Ẩn form login

                    // Show main form
                    Home mainForm = new Home();
                    mainForm.FormClosed += (s, args) => this.Close(); // Đóng form login khi form chính đóng
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    txtMatkhau.Text = ""; // Xóa mật khẩu
                    txtMatkhau.Focus(); // Focus vào ô mật khẩu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }

        // Thêm sự kiện nhấn Enter để đăng nhập
        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn tiếng "beep"
                login();
            }
        }
    }
}

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
            // Check login
            if (txtTaikhoan.Text == "admin" && txtMatkhau.Text == "admin")
            {
                _logged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
    }
}

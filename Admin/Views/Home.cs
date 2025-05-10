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
    public partial class Home: Form
    {
        private Form form;
        public Home()
        {
            InitializeComponent();
        }

        private void SetContentForm(Type type, params Object[] args)
        {
            if (type == null) return;

            if (form == null || form.GetType() != type)
            {
                form = (Form)Activator.CreateInstance(type, args);
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.AutoScroll = true;
            }

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);
            form.Show();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            loginForm.ShowDialog();

            if (!loginForm.Logged)
            {
                Close();
                return;
            }

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Relogin
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (!loginForm.Logged)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(UserForm));
        }

        private void buttonQLthietbi_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(DeviceForm));
        }

        private void buttonQLdatcho_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(ReservationForm));
        }

        private void buttonQLphieumuon_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(BorrowForm));
        }

        private void buttonXLVP_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(ViolationForm));
        }

        private void CheckinButton_Click(object sender, EventArgs e)
        {
            CheckinForm checkinForm = new CheckinForm();
            checkinForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(DeviceCategoryForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(Thongkecheckin));
        }
    }
}

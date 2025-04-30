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

namespace Admin.Views
{
    public partial class CheckinForm: Form
    {
        CheckinController checkinController = new CheckinController();
        public CheckinForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string mssv = studentCode.Text;
            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên.");
                return;
            }
            else
            {
                bool result = checkinController.Checkin(mssv);
                if (result)
                {
                    MessageBox.Show("Check-in thành công!");
                }
                else
                {
                    MessageBox.Show("Check-in thất bại!");
                }
            }
            Close();
        }
    }
}

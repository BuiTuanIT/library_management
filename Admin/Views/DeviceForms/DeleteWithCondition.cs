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

namespace Admin.Views.DeviceForms
{
    public partial class DeleteWithCondition: Form
    {
        private DeviceController deviceController = new DeviceController();

        public DeleteWithCondition()
        {
            InitializeComponent();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thiết bị!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tất cả các thiết bị có mã chứa '" + txtCode.Text + "' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (deviceController.DeleteDevicesByCodePattern(txtCode.Text))
                {
                    MessageBox.Show("Đã xóa thành công các thiết bị có mã chứa '" + txtCode.Text + "'");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể xóa các thiết bị. Vui lòng thử lại!");
                }
            }
        }
    }
}

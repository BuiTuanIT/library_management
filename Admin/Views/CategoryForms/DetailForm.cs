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

namespace Admin.Views.CategoryForms
{
    public partial class DetailForm: Form
    {
        private CategoryDeviceController categoryController = new CategoryDeviceController();

        public DetailForm()
        {
            InitializeComponent();
        }
        public DetailForm(int categoryId)
        {
            InitializeComponent();
            LoadCategoryDetails(categoryId);
        }

        private void LoadCategoryDetails(int categoryId)
        {
            var category = categoryController.GetCategoryById(categoryId);
            if (category != null)
            {
                txtID.Text = category.Id.ToString();
                txtName.Text = category.Name;
                txtNote.Text = category.Note;
                txtQuantity.Text = category.Quantity.ToString();
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtNote.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                var newCategory = new Device_Category
                {
                    Name = txtName.Text,
                    Note = txtNote.Text,
                    Quantity = int.Parse(txtQuantity.Text)
                };
                if (categoryController.AddCategory(newCategory))
                {
                    MessageBox.Show("Thêm danh mục thành công.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm danh mục thất bại.");
                }
            }
            else
            {
                var updatedCategory = new Device_Category
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Note = txtNote.Text,
                    Quantity = int.Parse(txtQuantity.Text)
                };
                if (categoryController.UpdateCategory(updatedCategory))
                {
                    MessageBox.Show("Cập nhật danh mục thành công.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục thất bại.");
                }
            }
        }
    }
}

using AdminApp.Controllers;
using MySql.Data.MySqlClient;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Controller
{
    class CategoryDeviceController
    {
        private DatabaseHelper db = new DatabaseHelper();
        public List<Device_Category> GetAllCategories()
        {
            string query = "SELECT * FROM device_category";
            DataTable dt = db.ExecuteQuery(query);
            List<Device_Category> categories = new List<Device_Category>();
            foreach (DataRow row in dt.Rows)
            {
                categories.Add(new Device_Category
                {
                    Id = Convert.ToInt32(row["category_id"]),
                    Name = row["devicename"].ToString(),
                    Note = row["note"].ToString(),
                    Quantity = Convert.ToInt32(row["quantity"])
                });
            }
            return categories;
        }
        
        public Device_Category GetCategoryById(int id)
        {
            string query = "SELECT * FROM device_category WHERE category_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Device_Category
                {
                    Id = Convert.ToInt32(row["category_id"]),
                    Name = row["devicename"].ToString(),
                    Note = row["note"].ToString(),
                    Quantity = Convert.ToInt32(row["quantity"])
                };
            }
            return null;
        }

        public bool AddCategory(Device_Category category)
        {
            // Kiểm tra xem tên danh mục đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM device_category WHERE devicename = @name";
            MySqlParameter[] checkParameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", category.Name)
            };
            int count = Convert.ToInt32(db.ExecuteQuery(checkQuery, checkParameters).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Tên danh mục đã tồn tại.");
                return false;
            }
            string query = "INSERT INTO device_category (devicename, note, quantity) VALUES (@name, @note, @quantity)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", category.Name),
                new MySqlParameter("@note", category.Note),
                new MySqlParameter("@quantity", category.Quantity)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public bool UpdateCategory(Device_Category category)
        {
            // Kiểm tra xem tên danh mục đã tồn tại chưa
            string checkQuery = "SELECT COUNT(*) FROM device_category WHERE devicename = @name AND category_id != @id";
            MySqlParameter[] checkParameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", category.Name),
                new MySqlParameter("@id", category.Id)
            };
            int count = Convert.ToInt32(db.ExecuteQuery(checkQuery, checkParameters).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Tên danh mục đã tồn tại.");
                return false;
            }
            string query = "UPDATE device_category SET devicename = @name, note = @note, quantity = @quantity WHERE category_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", category.Name),
                new MySqlParameter("@note", category.Note),
                new MySqlParameter("@quantity", category.Quantity),
                new MySqlParameter("@id", category.Id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public bool DeleteCategory(int id)
        {
            string checkQuery = "SELECT COUNT(*) FROM device WHERE category_id = @id";
            MySqlParameter[] checkParameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            int count = Convert.ToInt32(db.ExecuteQuery(checkQuery, checkParameters).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Không thể xóa danh mục này vì nó đang được sử dụng trong bảng device.");
                return false;
            }
            string query = "DELETE FROM device_category WHERE category_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
    }
}

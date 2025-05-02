using AdminApp.Controllers;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

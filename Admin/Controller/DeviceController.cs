using AdminApp.Controllers;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using MySql.Data.MySqlClient;

namespace Admin.Controller
{
    class DeviceController
    {
        private DatabaseHelper db = new DatabaseHelper();

        public List<Device> GetAllDevices()
        {
            string query = "SELECT * FROM device";
            DataTable dt = db.ExecuteQuery(query);
            List<Device> devices = new List<Device>();
            foreach (DataRow row in dt.Rows)
            {
                devices.Add(new Device
                {
                    Device_Id = Convert.ToInt32(row["device_id"]),
                    Category_Id = Convert.ToInt32(row["category_id"]),
                    Device_Code = row["device_code"].ToString(),
                    Status = row["status"].ToString(),
                    Is_Borrowed = Convert.ToInt32(row["is_borrow"])
                });
            }
            return devices;
        }

        public Device GetDeviceById(int deviceId)
        {
            string query = "SELECT * FROM device WHERE device_id = @device_id";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@device_id", deviceId)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Device
                {
                    Device_Id = Convert.ToInt32(row["device_id"]),
                    Category_Id = Convert.ToInt32(row["category_id"]),
                    Device_Code = row["device_code"].ToString(),
                    Status = row["status"].ToString(),
                    Is_Borrowed = Convert.ToInt32(row["is_borrow"])
                };
            }
            return null;
        }

        public bool AddDevice(Device device)
        {

            string query = "INSERT INTO DEVICE (category_id, device_code, status, is_borrow)" +
                "VALUE (@category_id, @device_code, @status, @is_borrow)";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@category_id", device.Category_Id),
                new MySqlParameter("@device_code", device.Device_Code),
                new MySqlParameter("@status", device.Status),
                new MySqlParameter("@is_borrow", device.Is_Borrowed)
            };

            return db.ExecuteNonQuery(query, parameters);
        }

        public bool UpdateDevice(Device device)
        {
            string query = "UPDATE device SET category_id = @category_id, device_code = @device_code, status = @status, is_borrow = @is_borrow WHERE device_id = @device_id";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@category_id", device.Category_Id),
                new MySqlParameter("@device_code", device.Device_Code),
                new MySqlParameter("@status", device.Status),
                new MySqlParameter("@is_borrow", device.Is_Borrowed),
                new MySqlParameter("@device_id", device.Device_Id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }

        public bool DeleteDevice(int deviceId)
        {
            string query = "DELETE FROM device WHERE device_id = @device_id";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@device_id", deviceId)
            };
            return db.ExecuteNonQuery(query, parameters);
        }

        public bool DeleteDevicesByCodePattern(string codePattern)
        {
            string query = "DELETE FROM device WHERE device_code LIKE @code_pattern";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@code_pattern", "%" + codePattern + "%")
            };
            return db.ExecuteNonQuery(query, parameters);
        }

        public List<Device> GetDeviceNotBorrow()
        {
            string query = "SELECT * FROM device WHERE is_borrow = 0";

            DataTable dt = db.ExecuteQuery(query);
            List<Device> devices = new List<Device>();
            foreach (DataRow row in dt.Rows) {
                devices.Add(new Device
                {
                    Device_Id = Convert.ToInt32(row["device_id"]),
                    Category_Id = Convert.ToInt32(row["category_id"]),
                    Device_Code = row["device_code"].ToString(),
                    Status = row["status"].ToString(),
                    Is_Borrowed = Convert.ToInt32(row["is_borrow"])
                });
            }
            return devices;
        }
    }
}

using AdminApp.Controllers;
using MySql.Data.MySqlClient;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Controller
{
    class BorrowController
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public List<Borrowrecords> GetAllBorrows()
        {
            string query = "SELECT * FROM borrowrecords";
            DataTable dataTable = dbHelper.ExecuteQuery(query);
            List<Borrowrecords> borrowRecords = new List<Borrowrecords>();
            foreach (DataRow row in dataTable.Rows)
            {
                Borrowrecords record = new Borrowrecords
                {
                    Id = Convert.ToInt32(row["borrow_id"]),
                    DeviceId = Convert.ToInt32(row["device_id"]),
                    UsertId = Convert.ToInt32(row["user_id"]),
                    Borrow_date = Convert.ToDateTime(row["borrow_date"]),
                    Return_date = Convert.ToDateTime(row["return_date"]),
                    Actual_return_date = Convert.ToDateTime(row["actual_return_date"])
                };
                borrowRecords.Add(record);
            }
            return borrowRecords;
        }

        public Borrowrecords GetBorrowById(int id)
        {
            string query = "SELECT * FROM borrowrecords WHERE borrow_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Borrowrecords
                {
                    Id = Convert.ToInt32(row["borrow_id"]),
                    DeviceId = Convert.ToInt32(row["device_id"]),
                    UsertId = Convert.ToInt32(row["user_id"]),
                    Borrow_date = Convert.ToDateTime(row["borrow_date"]),
                    Return_date = Convert.ToDateTime(row["return_date"]),
                    Actual_return_date = Convert.ToDateTime(row["actual_return_date"])
                };
            }
            return null;
        }

        public bool AddBorrow(Borrowrecords borrow)
        {
            string query = "INSERT INTO borrowrecords (device_id, user_id, borrow_date, return_date, actual_return_date) VALUES (@device_id, @user_id, @borrow_date, @return_date, @actual_return_date)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@device_id", borrow.DeviceId),
                new MySqlParameter("@user_id", borrow.UsertId),
                new MySqlParameter("@borrow_date", borrow.Borrow_date),
                new MySqlParameter("@return_date", borrow.Return_date),
                new MySqlParameter("@actual_return_date", borrow.Actual_return_date)
            };
            
            // Thêm bản ghi mượn
            bool borrowResult = dbHelper.ExecuteNonQuery(query, parameters);
            
            if (borrowResult)
            {
                // Cập nhật trạng thái thiết bị thành đã mượn
                string updateDeviceQuery = "UPDATE device SET is_borrow = 1, status = 'is_use' WHERE device_id = @device_id";
                MySqlParameter[] deviceParams = new MySqlParameter[]
                {
                    new MySqlParameter("@device_id", borrow.DeviceId)
                };
                return dbHelper.ExecuteNonQuery(updateDeviceQuery, deviceParams);
            }
            
            return false;
        }

        public bool UpdateBorrow(Borrowrecords borrow)
        {
            string query = "UPDATE borrowrecords SET device_id = @device_id, user_id = @user_id, borrow_date = @borrow_date, return_date = @return_date, actual_return_date = @actual_return_date WHERE borrow_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", borrow.Id),
                new MySqlParameter("@device_id", borrow.DeviceId),
                new MySqlParameter("@user_id", borrow.UsertId),
                new MySqlParameter("@borrow_date", borrow.Borrow_date),
                new MySqlParameter("@return_date", borrow.Return_date),
                new MySqlParameter("@actual_return_date", borrow.Actual_return_date)
            };
            dbHelper.ExecuteNonQuery(query, parameters);

            // Kiểm tra nếu trả muộn thì thêm vi phạm
            if (borrow.Actual_return_date > borrow.Return_date)
            {
                var violationController = new ViolationController();
                int lateDays = (int)Math.Ceiling((borrow.Actual_return_date - borrow.Return_date).TotalDays);
                decimal fineAmount = 15000 * lateDays;
                Violation violation = new Violation()
                {
                    UserId = borrow.UsertId,
                    DeviceId = borrow.DeviceId,
                    borrowId = borrow.Id,
                    ReservationsId = null, // hoặc 0 nếu không dùng reservation
                    ViolationType = "late_return",
                    ViolationDescription = "Bồi thường",
                    ViolationDate = DateTime.Now,
                    FineAmount = fineAmount,
                    ViolationStatus = "pending"
                };
                violationController.AddViolation(violation);
            }

            return true;
        }
        public bool DeleteBorrow(int id)
        {
            string query = "DELETE FROM borrowrecords WHERE borrow_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            return true;
        }
    }
}

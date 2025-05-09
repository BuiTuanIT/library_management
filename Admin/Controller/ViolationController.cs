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
    class ViolationController
    {
        private DatabaseHelper db = new DatabaseHelper();

        public List<Violation> GetViolations()
        {
            string query = "SELECT * FROM violations";
            var dt = db.ExecuteQuery(query);
            List<Violation> violations = new List<Violation>();
            foreach (DataRow row in dt.Rows)
            {
                violations.Add(new Violation
                {
                    ViolationId = Convert.ToInt32(row["violations_id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    DeviceId = Convert.ToInt32(row["device_id"]),
                    borrowId = Convert.ToInt32(row["borrow_id"]),
                    ReservationsId = row["reservations_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["reservations_id"]),
                    ViolationType = row["violation_type"].ToString(),
                    ViolationDescription = row["description"].ToString(),
                    ViolationDate = Convert.ToDateTime(row["date_reported"]),
                    ViolationStatus = row["status"].ToString(),
                    FineAmount = Convert.ToDecimal(row["fine_amount"])
                });
            }
            return violations;
        }

        public Violation GetViolationById(int violationId)
        {
            string query = "SELECT * FROM violations WHERE violations_id = @violationId";
            MySqlParameter[] parameters = new MySqlParameter[] { new MySqlParameter("@violationId", violationId) };
            var dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Violation
                {
                    ViolationId = Convert.ToInt32(row["violations_id"]),
                    UserId = Convert.ToInt32(row["user_id"]),
                    DeviceId = Convert.ToInt32(row["device_id"]),
                    borrowId = Convert.ToInt32(row["borrow_id"]),
                    ReservationsId = row["reservations_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["reservations_id"]),
                    ViolationType = row["violation_type"].ToString(),
                    ViolationDescription = row["description"].ToString(),
                    ViolationDate = Convert.ToDateTime(row["date_reported"]),
                    ViolationStatus = row["status"].ToString(),
                    FineAmount = Convert.ToDecimal(row["fine_amount"])
                };
            }
            return null;
        }

        public bool AddViolation(Violation violation)
        {
            string query = "INSERT INTO violations (user_id, device_id, borrow_id, reservations_id, violation_type, description, date_reported, status, fine_amount) " +
                           "VALUES (@userId, @deviceId, @borrowId, @reservationsId, @violationType, @violationDescription, @dateReported, @status, @fineAmount)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@userId", violation.UserId),
                new MySqlParameter("@deviceId", violation.DeviceId),
                new MySqlParameter("@borrowId", violation.borrowId),
                new MySqlParameter("@reservationsId", (object)violation.ReservationsId ?? DBNull.Value),
                new MySqlParameter("@violationType", violation.ViolationType),
                new MySqlParameter("@violationDescription", violation.ViolationDescription),
                new MySqlParameter("@dateReported", violation.ViolationDate),
                new MySqlParameter("@status", violation.ViolationStatus),
                new MySqlParameter("@fineAmount", violation.FineAmount)
            };
            bool result = db.ExecuteNonQuery(query, parameters);

            // Kiểm tra mô tả và khóa tài khoản nếu cần
            if (result && !string.IsNullOrEmpty(violation.ViolationDescription))
            {
                string desc = violation.ViolationDescription.ToLower();
                if (desc.Contains("khóa thẻ 1 tháng") || desc.Contains("khóa thẻ 2 tháng") || desc.Contains("Khóa thẻ 1 tháng và bồi thường"))
                {
                    string lockQuery = "UPDATE users SET is_active = 0,last_checkin = @dateReported WHERE user_id = @user_id";
                    MySqlParameter[] lockParams = {
                        new MySqlParameter("@user_id", violation.UserId), 
                        new MySqlParameter("@dateReported", violation.ViolationDate) 
                        };
                    db.ExecuteNonQuery(lockQuery, lockParams);
                }
            }

            return result;
        }

        public bool UpdateViolation(Violation violation)
        {
            string query = "UPDATE violations SET user_id = @userId, device_id = @deviceId, borrow_id = @borrowId, reservations_id = @reservationsId, violation_type = @violationType, description = @violationDescription, date_reported = @dateReported, status = @status, fine_amount = @fineAmount WHERE violations_id = @violationId";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@userId", violation.UserId),
                new MySqlParameter("@deviceId", violation.DeviceId),
                new MySqlParameter("@borrowId", violation.borrowId),
                new MySqlParameter("@reservationsId", violation.ReservationsId),
                new MySqlParameter("@violationType", violation.ViolationType),
                new MySqlParameter("@violationDescription", violation.ViolationDescription),
                new MySqlParameter("@dateReported", violation.ViolationDate),
                new MySqlParameter("@status", violation.ViolationStatus),
                new MySqlParameter("@fineAmount", violation.FineAmount),
                new MySqlParameter("@violationId", violation.ViolationId)
            };
            bool result = db.ExecuteNonQuery(query, parameters);
            // Kiểm tra mô tả và khóa tài khoản nếu cần
            if (result && !string.IsNullOrEmpty(violation.ViolationDescription))
            {
                string desc = violation.ViolationDescription.ToLower();
                if (desc.Contains("khóa thẻ 1 tháng") || desc.Contains("khóa thẻ 2 tháng") || desc.Contains("Khóa thẻ 1 tháng và bồi thường"))
                {
                    string lockQuery = "UPDATE users SET is_active = 0,last_checkin = @dateReported WHERE user_id = @user_id";
                    MySqlParameter[] lockParams = {
                        new MySqlParameter("@user_id", violation.UserId), 
                        new MySqlParameter("@dateReported", violation.ViolationDate) 
                        };
                    db.ExecuteNonQuery(lockQuery, lockParams);
                }
            }
            return result;
        }

        public bool DeleteViolation(int violationId)
        {
            string query = "DELETE FROM violations WHERE violations_id = @violationId";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@violationId", violationId)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
    }
}

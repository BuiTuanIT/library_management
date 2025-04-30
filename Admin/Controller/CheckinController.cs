using AdminApp.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Controller
{
    class CheckinController
    {
        private DatabaseHelper db = new DatabaseHelper();
        public bool Checkin(string studentCode)
        {
            // 1. Kiểm tra sinh viên có tồn tại không
            string checkQuery = "SELECT user_id FROM users WHERE student_code = @student_code";
            MySqlParameter[] checkParams = new MySqlParameter[]
            {
                new MySqlParameter("@student_code", studentCode)
            };

            object result = db.ExecuteScalar(checkQuery, checkParams);
            if (result == null)
            {
                MessageBox.Show("Sinh viên không tồn tại!");
                return false;
            }

            int userId = Convert.ToInt32(result);

            // 2. Cập nhật last_checkin
            string updateQuery = "UPDATE users SET last_checkin = @last_checkin WHERE student_code = @student_code";
            MySqlParameter[] updateParams = new MySqlParameter[]
            {
                new MySqlParameter("@last_checkin", DateTime.Now),
                new MySqlParameter("@student_code", studentCode)
            };
            db.ExecuteNonQuery(updateQuery, updateParams);

            // 3. Ghi log vào studyareaaccesslogs
            string insertQuery = "INSERT INTO studyareaaccesslogs (user_id, access_time) VALUES (@user_id, @access_time)";
            MySqlParameter[] insertParams = new MySqlParameter[]
            {
                new MySqlParameter("@user_id", userId),
                new MySqlParameter("@access_time", DateTime.Now)
            };

            bool inserted = db.ExecuteNonQuery(insertQuery, insertParams);
            if (!inserted)
            {
                MessageBox.Show("Lỗi khi ghi log vào bảng studyareaaccesslogs!");
                return false;
            }

            return true;
        }

    }
}

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
                MessageBox.Show("Chưa tồn tại thành viên");
                return false;
            }

            int userId = Convert.ToInt32(result);

            // 2. Kiểm tra xem sinh viên có vi phạm nào chưa giải quyết không
            string violationQuery = "SELECT COUNT(*) FROM violations WHERE user_id = @user_id AND status = 'pending'";
            MySqlParameter[] violationParams = new MySqlParameter[]
            {
                new MySqlParameter("@user_id", userId)
            };
            object violationCount = db.ExecuteScalar(violationQuery, violationParams);
            if (violationCount != null && Convert.ToInt32(violationCount) > 0)
            {
                MessageBox.Show("Sinh viên có vi phạm chưa được giải quyết!");
                return false;
            }

            // 3. Kiểm tra xem account sinh viên có bị khóa không
            string accountStatusQuery = "SELECT is_active FROM users WHERE is_active = @active";
            MySqlParameter[] accountStatusParams = new MySqlParameter[]
            {
                new MySqlParameter("@active", 0)
            };
            object accountStatus = db.ExecuteScalar(accountStatusQuery, accountStatusParams);
            if (accountStatus != null && Convert.ToInt32(accountStatus) == 0)
            {
                MessageBox.Show("Tài khoản sinh viên đã bị khóa!");
                return false;
            }

            // 4. Cập nhật last_checkin
            string updateQuery = "UPDATE users SET last_checkin = @last_checkin WHERE student_code = @student_code";
            MySqlParameter[] updateParams = new MySqlParameter[]
            {
                new MySqlParameter("@last_checkin", DateTime.Now),
                new MySqlParameter("@student_code", studentCode)
            };
            db.ExecuteNonQuery(updateQuery, updateParams);

            // 5. Ghi log vào studyareaaccesslogs
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

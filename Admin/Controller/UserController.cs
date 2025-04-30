using AdminApp.Controllers;
using ClosedXML.Excel;
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
    class UserController
    {
        private DatabaseHelper db = new DatabaseHelper();

        public List<Users> GetAllUsers()
        {
            string query = "SELECT * FROM users";
            DataTable dt = db.ExecuteQuery(query);
            List<Users> users = new List<Users>();
            foreach (DataRow row in dt.Rows)
            {
                 users.Add( new Users
                 {
                     UserId = Convert.ToInt32(row["user_id"]),
                     UserName = row["username"].ToString(),
                     Password = row["password"].ToString(),
                     Birthday = Convert.ToDateTime(row["birthday"]),
                     Sex = row["sex"].ToString(),
                     last_checkin = row["last_checkin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["last_checkin"]),
                     email = row["email"] == DBNull.Value ? null : row["email"].ToString(),
                     phone = row["phone"] == DBNull.Value ? null : row["phone"].ToString(),
                     student_code = row["student_code"] == DBNull.Value ? null : row["student_code"].ToString(),
                     is_active = Convert.ToInt32(row["is_active"])
                 });
            }
            return users;
        }

        public Users GetUsersById(int id)
        {
            string query = "SELECT * FROM users WHERE user_id = @user_id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@user_id", id)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Users
                {
                    UserId = Convert.ToInt32(row["user_id"]),
                    UserName = row["username"].ToString(),
                    Password = row["password"].ToString(),
                    Birthday = Convert.ToDateTime(row["birthday"]),
                    Sex = row["sex"].ToString(),
                    last_checkin = row["last_checkin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["last_checkin"]),
                    email = row["email"] == DBNull.Value ? null : row["email"].ToString(),
                    phone = row["phone"] == DBNull.Value ? null : row["phone"].ToString(),
                    student_code = row["student_code"] == DBNull.Value ? null : row["student_code"].ToString(),
                    is_active = Convert.ToInt32(row["is_active"])
                };
            }

            return null;
        }

        public bool AddUser(Users users)
        {
            // Kiểm tra xem user đã tồn tại ở bản ghi khác chưa
            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND student_code = @student_code";
            MySqlParameter[] checkParams = {
                new MySqlParameter("@username", users.UserName)
            };

            int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));
            if (count > 0)
            {
                MessageBox.Show("user đã tồn tại!");
                return false;
            }
            string query = "INSERT INTO USERS(user_id, username, password, birthday, sex, last_checkin, email, phone, student_code, is_active)"+
                "VALUES (@user_id, @username, @password, @birthday, @sex, @last_checkin, @email, @phone, @student_code, @is_active)";
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@user_id", users.UserId),
                new MySqlParameter("@username", users.UserName),
                new MySqlParameter("@password", users.Password),
                new MySqlParameter("@birthday", users.Birthday),
                new MySqlParameter("@sex", users.Sex),
                new MySqlParameter("@last_checkin", users.last_checkin),
                new MySqlParameter("@email", users.email),
                new MySqlParameter("@phone", users.phone),
                new MySqlParameter("@student_code", users.student_code),
                new MySqlParameter("@is_active", users.is_active)
            };
            return db.ExecuteNonQuery(query, parameter);
        }

        public bool UpdateUser(Users users)
        {
            // Kiểm tra xem username đã tồn tại ở bản ghi khác chưa
            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND user_id != @user_id";
            MySqlParameter[] checkParams = {
                new MySqlParameter("@username", users.UserName),
                new MySqlParameter("@user_id", users.UserId)
            };

            int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));
            if (count > 0)
            {
                MessageBox.Show("Username đã tồn tại!");
                return false;
            }
            string query = @"UPDATE users
                            SET username = @username, password = @password, birthday= @birthday, sex = @sex, email= @email, phone= @phone, is_active= @is_active, student_code= @student_code
                            WHERE user_id = @user_id";
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@user_id", users.UserId),
                new MySqlParameter("@username", users.UserName),
                new MySqlParameter("@password", users.Password),
                new MySqlParameter("@birthday", users.Birthday),
                new MySqlParameter("sex",users.Sex),
                new MySqlParameter("@email", users.email),
                new MySqlParameter("@phone", users.phone),
                new MySqlParameter("@student_code", users.student_code),
                new MySqlParameter("@is_active", users.is_active)
            };
            return db.ExecuteNonQuery(query, parameter);
        }

        public bool DeleteUser(int id)
        {
            string query = "DELETE FROM users WHERE user_id = @user_id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@user_id", id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }

        public bool DeleteWithCondition(Users users)
        {
            string query = "DELETE FROM users WHERE " +
                "last_checkin < @last_checkin and is_active = @is_active";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@last_checkin", users.last_checkin),
                new MySqlParameter("@is_active", users.is_active)
            };
            return db.ExecuteNonQuery(query, parameters);
        }


    }
}

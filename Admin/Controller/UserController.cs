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
                     last_checkin = row["last_checkin"].ToString(),
                     email = row["email"].ToString(),
                     phone = row["phone"].ToString(),
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
                    last_checkin = row["last_checkin"].ToString(),
                    email = row["email"].ToString(),
                    phone = row["phone"].ToString(),
                    is_active = Convert.ToInt32(row["is_active"])
                };
            }

            return null;
        }
    }
}

using AdminApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Shared.Models;
using MySql.Data.MySqlClient;

namespace Admin.Controller
{
    class ReservationController
    {
        private DatabaseHelper db = new DatabaseHelper();
        public List<Reservations> GetAllReservations()
        {
            string query = "SELECT * FROM reservations";
            DataTable dt = db.ExecuteQuery(query);
            List<Reservations> reservations = new List<Reservations>();
            foreach (DataRow row in dt.Rows)
            {
                reservations.Add(new Reservations()
                {
                    Id = Convert.ToInt32(row["reservations_id"]),
                    Device_Id = Convert.ToInt32(row["device_id"]),
                    User_Id = Convert.ToInt32(row["user_id"]),
                    Start_Date = Convert.ToDateTime(row["reserve_start"]),
                    End_Date = Convert.ToDateTime(row["reserve_end"]),
                    Status = row["status"].ToString()
                });
            }
            return reservations;
        }

        public List<Reservations> GetReservationsById(int Id)
        {
            string query = "SELECT * FROM reservations WHERE reservations_id = @reservations_id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@reservation_id", Id)
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            List<Reservations> reservations = new List<Reservations>();
            foreach (DataRow row in dt.Rows)
            {
                reservations.Add(new Reservations()
                {
                    Id = Convert.ToInt32(row["reservations_id"]),
                    Device_Id = Convert.ToInt32(row["device_id"]),
                    User_Id = Convert.ToInt32(row["user_id"]),
                    Start_Date = Convert.ToDateTime(row["reserve_start"]),
                    End_Date = Convert.ToDateTime(row["reserve_end"]),
                    Status = row["status"].ToString()
                });
            }
            return reservations;
        }

        public bool AddReservation(Reservations reservation)
        {
            string query = "INSERT INTO reservations (device_id, user_id, reserve_start, reserve_end, status) VALUES (@deviceId, @userId, @startDate, @endDate, @status)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@deviceId", reservation.Device_Id),
                new MySqlParameter("@userId", reservation.User_Id),
                new MySqlParameter("@startDate", reservation.Start_Date),
                new MySqlParameter("@endDate", reservation.End_Date),
                new MySqlParameter("@status", reservation.Status)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public bool UpdateReservation(Reservations reservation)
        {
            string query = "UPDATE reservations SET device_id = @deviceId, user_id = @userId, reserve_start = @startDate, reserve_end = @endDate, status = @status WHERE reservations_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@deviceId", reservation.Device_Id),
                new MySqlParameter("@userId", reservation.User_Id),
                new MySqlParameter("@startDate", reservation.Start_Date),
                new MySqlParameter("@endDate", reservation.End_Date),
                new MySqlParameter("@status", reservation.Status),
                new MySqlParameter("@id", reservation.Id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
        public bool DeleteReservation(int id)
        {
            string query = "DELETE FROM reservations WHERE reservations_id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            return db.ExecuteNonQuery(query, parameters);
        }
    }
}

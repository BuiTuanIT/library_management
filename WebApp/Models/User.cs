using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("username")]
        public string UserName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("birthday")]
        public DateTime? Birthday { get; set; }
        [Column("sex")]
        public string? Sex { get; set; }
        [Column("last_checkin")]
        public DateTime? last_checkin { get; set; }
        [Column("email")]
        public string? email { get; set; }
        [Column("phone")]
        public string? phone { get; set; }
        [Column("is_active")]
        public int? is_active { get; set; }
        [Column("student_code")]
        public string? student_code { get; set; }

    }
}

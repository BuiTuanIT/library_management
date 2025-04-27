using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Users
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("password")]
        public string Password { get; set; }

        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string last_checkin { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int is_active { get; set; }

    }
}

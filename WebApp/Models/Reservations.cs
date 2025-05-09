using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Reservations
    {
        [Key]
        [Column("reservations_id")]
        public int Reservations_Id { get; set; }

        [Column("device_id")]
        public int Device_Id { get; set; }

        [Column("user_id")]
        public int User_Id { get; set; }

        [Column("reserve_start")]
        public DateTime Reserve_Start { get; set; }

        [Column("reserve_end")]
        public DateTime Reserve_End { get; set; }

        [Column("status")]
        public string Status { get; set; }

        // Navigation properties
        [ForeignKey("Device_Id")]
        public virtual Device Device { get; set; }

        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
    }
}

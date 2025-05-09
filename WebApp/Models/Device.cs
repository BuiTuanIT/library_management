using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Device
    {
        [Key]
        [Column("device_id")]
        public int Device_Id { get; set; }

        [Column("category_id")]
        public int Category_Id { get; set; }

        [Column("device_code")]
        public string Device_Code { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("is_borrow")]
        public bool Is_Borrow { get; set; }

        // Navigation property
        public Device_Category Category { get; set; }
    }
}

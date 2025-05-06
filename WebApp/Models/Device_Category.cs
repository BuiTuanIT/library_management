using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Device_Category
    {
        [Key]
        [Column("category_id")]
        public int Category_Id { get; set; }

        [Column("devicename")]
        public string DeviceName { get; set; }

        [Column("note")]
        public string Note { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}

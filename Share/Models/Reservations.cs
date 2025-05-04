using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public int Device_Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Status { get; set; }
    }
}

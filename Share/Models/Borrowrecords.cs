using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Borrowrecords
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int UsertId { get; set; }
        public DateTime Borrow_date { get; set; }
        public DateTime Return_date { get; set; }
        public DateTime Actual_return_date { get; set; }
    }
}

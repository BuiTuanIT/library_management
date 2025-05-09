using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Violation
    {
        public int ViolationId { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int borrowId { get; set; }
        public int? ReservationsId { get; set; }
        public string ViolationType { get; set; }
        public string ViolationDescription { get; set; }
        public DateTime ViolationDate { get; set; }
        public string ViolationStatus { get; set; }
        public decimal FineAmount { get; set; }
    }
}

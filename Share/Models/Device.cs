using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Device
    {
        public int Device_Id { get; set; }
        public int Category_Id { get; set; }
        public string Device_Code { get; set; }
        public string Status { get; set; }
        public int Is_Borrowed { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotspotAPI.Models
{
    public class Hotspot
    {
        public int HotspotId { get; set; }
        public string HotspotName { get; set; }
        public string Password { get; set; }
        public string SerialNumber { get; set; }
        public string AdminPassword { get; set; }
        public string MobileNumber { get; set; }
        public string SIM {get; set;}
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class Machine : EquipmentDetail
    {
        public int MachineID { get; set; }
        public MachineType MachineType { get; set; }   
    }
}
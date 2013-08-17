using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class Equipment : EquipmentDetail
    {
        public int EquipmentID { get; set; }
        public EquipmentType EquipmentType { get; set; }
        

    }
}
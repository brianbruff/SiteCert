using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class EquipmentDetail
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SerialNr { get; set; }
        public string CertNr { get; set; }
        public string Swl { get; set; }
        public string ConfigurationSettings { get; set; }
        public string TestParticulars { get; set; }
        public string Tester { get; set; }
        public DateTime? InspectionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }   
    }
}
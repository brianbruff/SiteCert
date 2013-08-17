using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class TrainingRecord
    {
        public int TrainingRecordID { get; set; }
        public string Course { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public byte[] Cert { get; set; }
    }
}
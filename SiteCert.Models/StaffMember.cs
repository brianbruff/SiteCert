using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class StaffMember
    {
        public int StaffMemberID { get; set; }
        public int Number { get; set; }
        public string SafePass { get; set; }
        public DateTime StartDate { get; set; }
        public string Position { get; set; }
        public string StaffType { get; set; }
    }
}
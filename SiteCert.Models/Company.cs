using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteCert.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Url)]
        public string Website { get; set; }

        // Will get all these details from the company contact
        //public string ContactName { get; set; }
        //public string ContactPhoneNumber { get; set; }
        //public string ContactEmailAddress { get; set; }

        public string CompanyContactUserId { get; set; }

        public byte[] Logo { get; set; }

        public virtual List<EquipmentType> EquiptmentTypes { get; set; }
        public virtual List<MachineType> MachineTypes { get; set; }
        public virtual List<DocumentType> DocumentTypes { get; set; }

        public virtual List<User> Users { get; set; }

        public virtual List<Document> Documents { get; set; }
        public virtual List<Machine> Machines { get; set; }
        public virtual List<Equipment> Equiptments { get; set; }

    }
}
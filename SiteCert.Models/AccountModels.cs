using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCert.Models
{
    public class SiteCertUser : User
    {
        public SiteCertUser()
            :base()
        {

        }

        public SiteCertUser(string userName)
            : base(userName)
        {

        }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}

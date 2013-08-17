using Microsoft.AspNet.Identity.EntityFramework;
using SiteCert.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace SiteCert.Data
{
    public class SiteCertDbContext : IdentityDbContext<SiteCertUser, UserClaim, UserSecret, UserLogin, Role, UserRole>
    {
        public SiteCertDbContext()
            : base("SiteCertContext")
        {
            
        }

        public SiteCertDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        

        public DbSet<SiteCert.Models.Company> Companies { get; set; }        
    }
}
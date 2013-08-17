using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SiteCert.Utils.Security
{
    public class RoleManager
    {
        public const string ADMIN_ROLE = "Admin";
        public const string COMPANY_ROLE = "Company";

        public async static Task<bool> InitAppRoles(IdentityStoreManager identityStore)        
        {            
            if (!(await identityStore.Context.Roles.RoleExists(ADMIN_ROLE)))
                await identityStore.Context.Roles.CreateRole(new Role(ADMIN_ROLE));
            if (!(await identityStore.Context.Roles.RoleExists(COMPANY_ROLE)))
                await identityStore.Context.Roles.CreateRole(new Role(COMPANY_ROLE));

            return true;
        }

        
    }
}
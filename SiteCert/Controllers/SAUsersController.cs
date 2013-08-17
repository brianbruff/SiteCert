using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteCert.Models;
using SiteCert.Data;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SiteCert.Controllers
{
    public class SAUsersController : Controller
    {
        //private IdentityDbContext securityDb = new IdentityDbContext();
        private SiteCertDbContext db = new SiteCertDbContext();

        //
        // GET: /SuperAdmin/Users/
        async public Task<ActionResult> Index()
        {
            // Get users in admin role
            var adminUsers = db.Users.Join(db.UserRoles.Where(ur => ur.RoleId == "CompanyAdmin"),
                role => role.Id,
                user => user.UserId,
                (user, role) => user);
            
            return View(await adminUsers.ToListAsync());

        }

        //
        // GET: /SuperAdmin/Users/Details/5
        public ActionResult Details(String id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }       
        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

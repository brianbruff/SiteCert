using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SiteCert.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SiteCert.Controllers
{
    public class HomeController : Controller
    {
        async public Task<ActionResult> Index()
        {
            var result = User.IsInRole("Admin");


            var a = new IdentityStoreContext(new SiteCertDbContext());
            var identityStore = new IdentityStoreManager(new IdentityStoreContext(new SiteCertDbContext()));

            var x =  await a.Roles.IsUserInRole("Admin", "Admin");
            //result = ctx.Roles.IsUserInRole("Admin", "Admin");
            
            
            
            
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
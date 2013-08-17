using SiteCert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SiteCert.Controllers
{
    public class StaffController : Controller
    {
        public ActionResult Index(string company)
        {
            List<StaffMember> model = new List<StaffMember>();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}

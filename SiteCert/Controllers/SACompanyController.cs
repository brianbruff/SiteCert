using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteCert.Models;
using SiteCert.Data;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SiteCert.Controllers
{
    [Authorize(Roles="SuperAdmin")]
    public class SACompanyController : Controller
    {
        private SiteCertDbContext db = new SiteCertDbContext();       

        //
        // GET: /Admin/Company/
        async public Task<ActionResult> Index()
        {
            var users = await db.Users.ToListAsync();
            var companies = await db.Companies.ToListAsync();
            companies.ForEach(c => 
                {
                    c.CompanyContactUserId = users.FirstOrDefault(u => u.Id == c.CompanyContactUserId).UserName;
                });

            return View(companies);
        }

        //
        // GET: /Admin/Company/Details/5
        public ActionResult Details(Int32 id)
        {
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        //
        // GET: /Admin/Company/Create
        async public Task<ActionResult> Create()
        {
            // Get users in companyAdmin role not already asigned
            var companyAdmins = await db.Companies.Select(c => c.CompanyContactUserId).ToListAsync();
            var adminUsers = db.Users.Join(db.UserRoles.Where(ur =>  ur.RoleId == "CompanyAdmin" && !companyAdmins.Contains(ur.UserId)),
                role => role.Id,
                user => user.UserId,
                (user, role) => user);

            var aca = await adminUsers.ToListAsync();
            ViewBag.AvailableCompanyAdmins = aca.Select(a => new SelectListItem { Text = a.UserName, Value = a.Id }).ToList();
            return View();
        }

        //
        // POST: /Admin/Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(company);
        }

        //
        // GET: /Admin/Company/Edit/5
        async public Task<ActionResult> Edit(Int32 id)
        {
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }


            var aca = await GetAvailableCompanyAdmins();
            // Add the current user for the edit
            var currentCompanyAdmin = db.Users.FirstOrDefault(u => u.Id == company.CompanyContactUserId);
            if (currentCompanyAdmin != null)
                aca.Add(currentCompanyAdmin);
            ViewBag.AvailableCompanyAdmins = aca.Select(a => new SelectListItem { Text = a.UserName, Value = a.Id }).ToList();


            return View(company);
        }

        private async Task<List<SiteCertUser>> GetAvailableCompanyAdmins()
        {
            var companyAdmins = await db.Companies.Select(c => c.CompanyContactUserId).ToListAsync();
            var adminUsers = db.Users.Join(db.UserRoles.Where(ur => ur.RoleId == "CompanyAdmin" && !companyAdmins.Contains(ur.UserId)),
                role => role.Id,
                user => user.UserId,
                (user, role) => user);

            var aca = await adminUsers.ToListAsync();
            return aca;
        }

        //
        // POST: /Admin/Company/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        //
        // GET: /Admin/Company/Delete/5
        public ActionResult Delete(Int32 id)
        {
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        //
        // POST: /Admin/Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Int32 id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}

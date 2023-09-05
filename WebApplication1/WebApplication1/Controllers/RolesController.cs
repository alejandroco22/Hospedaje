using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Context;
using WebApplication1.Models;
using System.Net;

namespace WebApplication1.Controllers
{
    public class RolesController : Controller
    {
        private DataStore db2 = new DataStore();
        public object Roles { get; private set; }
        // GET: Roles
        public ActionResult Index()
        {
            return View(db2.Roles.ToList());
        }

        // GET: Roles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Rol Y = db2.Roles.Find(id);
                if (Y == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(Y);
                }
            }
        }

        // GET: Roles/Create
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(Rol Roles)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db2.Roles.Add(Roles);
                    db2.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Roles);
            }
            catch
            {
                return View(Roles);
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Rol Y = db2.Roles.Find(id);
                if (Y == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(Y);
                }
            }
        }

        // POST: Roles/Edit/5
        [HttpPost]
        public ActionResult Edit(Rol Y)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db2.Entry(Y).State = EntityState.Modified;
                    db2.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Y);
            }
            catch
            {
                return View(Y);
            }
        }
    }
}

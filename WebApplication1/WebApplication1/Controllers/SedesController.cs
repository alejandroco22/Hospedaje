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
    public class SedesController : Controller
    {
        private DataStore db4 = new DataStore();
        // GET: Sedes
        public ActionResult Index()
        {
            return View(db4.Sedes.ToList());
        }

        // GET: Sedes/Details/5
        public ActionResult Detail (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Sede W = db4.Sedes.Find(id);
                if (W == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(W);
                }
            }
        }
        // GET: Sedes/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sedes/Create
        [HttpPost]
        public ActionResult Create(Sede Sedes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db4.Sedes.Add(Sedes);
                    db4.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Sedes);
            }
            catch
            {
                return View(Sedes);
            }
        }

        // GET: Sedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Sede W = db4.Sedes.Find(id);
                if (W == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(W);
                }
            }
        }

        // POST: Sedes/Edit/5
        [HttpPost]
        public ActionResult Edit( Sede W)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db4.Entry(W).State = EntityState.Modified;
                    db4.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(W);
            }
            catch
            {
                return View(W);
            }
        }
    }
}

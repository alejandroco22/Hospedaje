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
    public class BitacorasController : Controller
    {
        private DataStore db6 = new DataStore();
        // GET: Bitacoras
        public ActionResult Index()
        {
            return View(db6.Bitacoras.ToList());
        }

        // GET: Bitacoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Bitacora U = db6.Bitacoras.Find(id);
                if (U == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(U);
                }
            }
        }

        // GET: Bitacoras/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bitacoras/Create
        [HttpPost]
        public ActionResult Create(Bitacora Bitacoras)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db6.Bitacoras.Add(Bitacoras);
                    db6.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Bitacoras);
            }
            catch
            {
                return View(Bitacoras);
            }
        }

        // GET: Bitacoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Bitacora U = db6.Bitacoras.Find(id);
                if (U == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(U);
                }
            }
        }

        // POST: Bitacoras/Edit/5
        [HttpPost]
        public ActionResult Edit(Bitacora U)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db6.Entry(U).State = EntityState.Modified;
                    db6.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(U);
            }
            catch
            {
                return View(U);
            }
        }
    }
}

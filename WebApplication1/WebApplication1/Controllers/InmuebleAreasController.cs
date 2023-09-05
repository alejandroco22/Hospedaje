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
    public class InmuebleAreasController : Controller
    {
        private DataStore db3 = new DataStore();
        // GET: InmuebleAreas
        public ActionResult Index()
        {
            return View(db3.InmuebleAreas.ToList());
        }

        // GET: InmuebleAreas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                InmuebleArea X = db3.InmuebleAreas.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View();
                }
            }
        }

        // GET: InmuebleAreas/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: InmuebleAreas/Create
        [HttpPost]
        public ActionResult Create(InmuebleArea InmuebleAreas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db3.InmuebleAreas.Add(InmuebleAreas);
                    db3.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(InmuebleAreas);
            }
            catch
            {
                return View(InmuebleAreas);
            }
        }
        // GET: InmuebleAreas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                InmuebleArea X = db3.InmuebleAreas.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View();
                }
            }
        }

        // POST: InmuebleAreas/Edit/5
        [HttpPost]
        public ActionResult Edit(InmuebleArea X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db3.Entry(X).State = EntityState.Modified;
                    db3.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(X);
            }
            catch
            {
                return View(X);
            }
        }
    }
}

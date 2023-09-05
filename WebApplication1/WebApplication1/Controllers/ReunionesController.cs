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
    public class ReunionesController : Controller
    {
        private DataStore db5 = new DataStore();
        // GET: Reuniones
        public ActionResult Index()
        {
            return View(db5.Reuniones.ToList());
        }

        // GET: Reuniones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Reunion V = db5.Reuniones.Find(id);
                if (V == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(V);
                }
            }
        }

        // GET: Reuniones/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reuniones/Create
        [HttpPost]
        public ActionResult Create(Reunion Reuniones)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db5.Reuniones.Add(Reuniones);
                    db5.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Reuniones);
            }
            catch
            {
                return View(Reuniones);
            }
        }

        // GET: Reuniones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Reunion V = db5.Reuniones.Find(id);
                if (V == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(V);
                }
            }
        }

        // POST: Reuniones/Edit/5
        [HttpPost]
        public ActionResult Edit(Reunion V)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db5.Entry(V).State = EntityState.Modified;
                    db5.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(V);
            }
            catch
            {
                return View(V);
            }
        }
    }
}

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
    public class UsuariosController : Controller
    {
        private DataStore db1 = new DataStore();

        public object Usuarios { get; private set; }

        // GET: Usuarios 
        public ActionResult Index()
        {
            return View(db1.Usuarios.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Usuario Z = db1.Usuarios.Find(id);
                if (Z == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(Z);
                }
            }
        }

        // GET: Usuarios/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuario Usuarios)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db1.Usuarios.Add(Usuarios);
                    db1.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Usuarios);
            }
            catch
            {
                return View(Usuarios);
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Usuario Z = db1.Usuarios.Find(keyValues: id);
                if (Z == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(Z);
                }
            }
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuario Z)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db1.Entry(Z).State =EntityState.Modified;
                    db1.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Z);
            }
            catch
            {
                return View(Z);
            }
        }      
    }
}

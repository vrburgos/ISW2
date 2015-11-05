using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISW2PDT5.Controllers
{
    public class SeccionesBodegaController : Controller
    {
        private mydbEntities db = new mydbEntities();

        //
        // GET: /SeccionesBodega/

        public ActionResult Index()
        {
            return View(db.seccion_bodega.ToList());
        }

        //
        // GET: /SeccionesBodega/Details/5

        public ActionResult Details(int id = 0)
        {
            seccion_bodega seccion_bodega = db.seccion_bodega.Find(id);
            if (seccion_bodega == null)
            {
                return HttpNotFound();
            }
            return View(seccion_bodega);
        }

        //
        // GET: /SeccionesBodega/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SeccionesBodega/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(seccion_bodega seccion_bodega)
        {
            if (ModelState.IsValid)
            {
                db.seccion_bodega.Add(seccion_bodega);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seccion_bodega);
        }

        //
        // GET: /SeccionesBodega/Edit/5

        public ActionResult Edit(int id = 0)
        {
            seccion_bodega seccion_bodega = db.seccion_bodega.Find(id);
            if (seccion_bodega == null)
            {
                return HttpNotFound();
            }
            return View(seccion_bodega);
        }

        //
        // POST: /SeccionesBodega/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(seccion_bodega seccion_bodega)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seccion_bodega).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seccion_bodega);
        }

        //
        // GET: /SeccionesBodega/Delete/5

        public ActionResult Delete(int id = 0)
        {
            seccion_bodega seccion_bodega = db.seccion_bodega.Find(id);
            if (seccion_bodega == null)
            {
                return HttpNotFound();
            }
            return View(seccion_bodega);
        }

        //
        // POST: /SeccionesBodega/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            seccion_bodega seccion_bodega = db.seccion_bodega.Find(id);
            db.seccion_bodega.Remove(seccion_bodega);
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
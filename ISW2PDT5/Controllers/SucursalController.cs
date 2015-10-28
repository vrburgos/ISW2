using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISW2PDT5.Controllers
{
    public class SucursalController : Controller
    {
        private mydbEntities db = new mydbEntities();

        //
        // GET: /Sucursal/

        public ActionResult Index()
        {
            var sucursals = db.sucursals.Include(s => s.municipio);
            return View(sucursals.ToList());
        }

        //
        // GET: /Sucursal/Details/5

        public ActionResult Details(int id = 0)
        {
            sucursal sucursal = db.sucursals.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        //
        // GET: /Sucursal/Create

        public ActionResult Create()
        {
            ViewBag.MUNICIPIO_id_municipio = new SelectList(db.municipios, "id_municipio", "mun_nom");
            return View();
        }

        //
        // POST: /Sucursal/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.sucursals.Add(sucursal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MUNICIPIO_id_municipio = new SelectList(db.municipios, "id_municipio", "mun_nom", sucursal.MUNICIPIO_id_municipio);
            return View(sucursal);
        }

        //
        // GET: /Sucursal/Edit/5

        public ActionResult Edit(int id = 0)
        {
            sucursal sucursal = db.sucursals.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            ViewBag.MUNICIPIO_id_municipio = new SelectList(db.municipios, "id_municipio", "mun_nom", sucursal.MUNICIPIO_id_municipio);
            return View(sucursal);
        }

        //
        // POST: /Sucursal/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MUNICIPIO_id_municipio = new SelectList(db.municipios, "id_municipio", "mun_nom", sucursal.MUNICIPIO_id_municipio);
            return View(sucursal);
        }

        //
        // GET: /Sucursal/Delete/5

        public ActionResult Delete(int id = 0)
        {
            sucursal sucursal = db.sucursals.Find(id);
            if (sucursal == null)
            {
                return HttpNotFound();
            }
            return View(sucursal);
        }

        //
        // POST: /Sucursal/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sucursal sucursal = db.sucursals.Find(id);
            db.sucursals.Remove(sucursal);
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstStuff.Models.Canada;
using CodeFirstStuff.Models.Db;

namespace CodeFirstStuff.Controllers
{
    public class Cities1Controller : Controller
    {
        private CanadaContext db = new CanadaContext();

        // GET: Cities1
        public ActionResult Index()
        {
            var cities = db.Cities.Include(c => c.Province);
            return View(cities.ToList());
        }

        // GET: Cities1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // GET: Cities1/Create
        public ActionResult Create()
        {
            ViewBag.ProvinceCode = new SelectList(db.Provinces, "ProvinceCode", "ProvinceName");
            return View();
        }

        // POST: Cities1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityId,CityName,Papulation,ProvinceCode")] City city)
        {
            if (ModelState.IsValid)
            {
                db.Cities.Add(city);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProvinceCode = new SelectList(db.Provinces, "ProvinceCode", "ProvinceName", city.ProvinceCode);
            return View(city);
        }

        // GET: Cities1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProvinceCode = new SelectList(db.Provinces, "ProvinceCode", "ProvinceName", city.ProvinceCode);
            return View(city);
        }

        // POST: Cities1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId,CityName,Papulation,ProvinceCode")] City city)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProvinceCode = new SelectList(db.Provinces, "ProvinceCode", "ProvinceName", city.ProvinceCode);
            return View(city);
        }

        // GET: Cities1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // POST: Cities1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            City city = db.Cities.Find(id);
            db.Cities.Remove(city);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

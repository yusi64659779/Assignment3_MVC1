using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment3_F19.Models;

namespace Assignment3_F19.Controllers
{
    public class AgriProductsController : Controller
    {
        private AgricultureDatabaseEntities db = new AgricultureDatabaseEntities();

        // GET: AgriProducts
        public ActionResult Index()
        {
            return View(db.AgriProducts.ToList());
        }

        // GET: AgriProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgriProduct agriProduct = db.AgriProducts.Find(id);
            if (agriProduct == null)
            {
                return HttpNotFound();
            }
            return View(agriProduct);
        }

        // GET: AgriProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgriProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_ID,Product_Name")] AgriProduct agriProduct)
        {
            if (ModelState.IsValid)
            {
                db.AgriProducts.Add(agriProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agriProduct);
        }

        // GET: AgriProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgriProduct agriProduct = db.AgriProducts.Find(id);
            if (agriProduct == null)
            {
                return HttpNotFound();
            }
            return View(agriProduct);
        }

        // POST: AgriProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_ID,Product_Name")] AgriProduct agriProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agriProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agriProduct);
        }

        // GET: AgriProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgriProduct agriProduct = db.AgriProducts.Find(id);
            if (agriProduct == null)
            {
                return HttpNotFound();
            }
            return View(agriProduct);
        }

        // POST: AgriProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgriProduct agriProduct = db.AgriProducts.Find(id);
            db.AgriProducts.Remove(agriProduct);
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

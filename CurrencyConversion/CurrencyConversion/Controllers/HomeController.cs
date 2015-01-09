using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CurrencyConverter.Models;
using CurrencyConversion.Models;

namespace CurrencyConversion.Controllers
{
    public class HomeController : Controller
    {
        private ConversionContext db = new ConversionContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.ConversionRates.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            ConversionRate conversionrate = db.ConversionRates.Find(id);
            if (conversionrate == null)
            {
                return HttpNotFound();
            }
            return View(conversionrate);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConversionRate conversionrate)
        {
            if (ModelState.IsValid)
            {
                db.ConversionRates.Add(conversionrate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conversionrate);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ConversionRate conversionrate = db.ConversionRates.Find(id);
            if (conversionrate == null)
            {
                return HttpNotFound();
            }
            return View(conversionrate);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ConversionRate conversionrate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conversionrate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conversionrate);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ConversionRate conversionrate = db.ConversionRates.Find(id);
            if (conversionrate == null)
            {
                return HttpNotFound();
            }
            return View(conversionrate);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConversionRate conversionrate = db.ConversionRates.Find(id);
            db.ConversionRates.Remove(conversionrate);
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
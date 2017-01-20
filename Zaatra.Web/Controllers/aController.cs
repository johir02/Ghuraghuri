using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models;

namespace Zaatra.Controllers
{
    public class aController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        //
        // GET: /a/

        public ActionResult Index()
        {
            var visainformations = db.VisaInformations.Include(v => v.Country);
            return View(visainformations.ToList());
        }

        //
        // GET: /a/Details/5

        public ActionResult Details(int id = 0)
        {
            VisaInformation visainformation = db.VisaInformations.Find(id);
            if (visainformation == null)
            {
                return HttpNotFound();
            }
            return View(visainformation);
        }

        //
        // GET: /a/Create

        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name");
            return View();
        }

        //
        // POST: /a/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VisaInformation visainformation)
        {
            if (ModelState.IsValid)
            {
                db.VisaInformations.Add(visainformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", visainformation.CountryId);
            return View(visainformation);
        }

        //
        // GET: /a/Edit/5

        public ActionResult Edit(int id = 0)
        {
            VisaInformation visainformation = db.VisaInformations.Find(id);
            if (visainformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", visainformation.CountryId);
            return View(visainformation);
        }

        //
        // POST: /a/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VisaInformation visainformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visainformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", visainformation.CountryId);
            return View(visainformation);
        }

        //
        // GET: /a/Delete/5

        public ActionResult Delete(int id = 0)
        {
            VisaInformation visainformation = db.VisaInformations.Find(id);
            if (visainformation == null)
            {
                return HttpNotFound();
            }
            return View(visainformation);
        }

        //
        // POST: /a/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisaInformation visainformation = db.VisaInformations.Find(id);
            db.VisaInformations.Remove(visainformation);
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
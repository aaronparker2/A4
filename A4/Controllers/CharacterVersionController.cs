using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A4.Models;

namespace A4.Controllers
{
    public class CharacterVersionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CharacterVersion
        public ActionResult Index()
        {
            return View(db.CharacterVersions.ToList());
        }

        // GET: CharacterVersion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacterVersion characterVersion = db.CharacterVersions.Find(id);
            if (characterVersion == null)
            {
                return HttpNotFound();
            }
            return View(characterVersion);
        }

        // GET: CharacterVersion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CharacterVersion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CharacterVersionID,CharacterName,Version")] CharacterVersion characterVersion)
        {
            if (ModelState.IsValid)
            {
                db.CharacterVersions.Add(characterVersion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(characterVersion);
        }

        // GET: CharacterVersion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacterVersion characterVersion = db.CharacterVersions.Find(id);
            if (characterVersion == null)
            {
                return HttpNotFound();
            }
            return View(characterVersion);
        }

        // POST: CharacterVersion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CharacterVersionID,CharacterName,Version")] CharacterVersion characterVersion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(characterVersion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(characterVersion);
        }

        // GET: CharacterVersion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharacterVersion characterVersion = db.CharacterVersions.Find(id);
            if (characterVersion == null)
            {
                return HttpNotFound();
            }
            return View(characterVersion);
        }

        // POST: CharacterVersion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CharacterVersion characterVersion = db.CharacterVersions.Find(id);
            db.CharacterVersions.Remove(characterVersion);
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

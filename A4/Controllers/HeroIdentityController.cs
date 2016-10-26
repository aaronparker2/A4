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
    public class HeroIdentityController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HeroIdentity
        public ActionResult Index()
        {
            return View(db.HeroIdentities.ToList());
        }

        // GET: HeroIdentity/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeroIdentity heroIdentity = db.HeroIdentities.Find(id);
            if (heroIdentity == null)
            {
                return HttpNotFound();
            }
            return View(heroIdentity);
        }

        // GET: HeroIdentity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroIdentity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CharacterName,IdentityName,Email")] HeroIdentity heroIdentity)
        {
            if (ModelState.IsValid)
            {
                db.HeroIdentities.Add(heroIdentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(heroIdentity);
        }

        // GET: HeroIdentity/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeroIdentity heroIdentity = db.HeroIdentities.Find(id);
            if (heroIdentity == null)
            {
                return HttpNotFound();
            }
            return View(heroIdentity);
        }

        // POST: HeroIdentity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CharacterName,IdentityName,Email")] HeroIdentity heroIdentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(heroIdentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(heroIdentity);
        }

        // GET: HeroIdentity/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeroIdentity heroIdentity = db.HeroIdentities.Find(id);
            if (heroIdentity == null)
            {
                return HttpNotFound();
            }
            return View(heroIdentity);
        }

        // POST: HeroIdentity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HeroIdentity heroIdentity = db.HeroIdentities.Find(id);
            db.HeroIdentities.Remove(heroIdentity);
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

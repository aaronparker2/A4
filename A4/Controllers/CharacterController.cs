using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A4.Models;
using A4.DAL;
using A4.ViewModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PagedList;

namespace A4.Controllers
{
    public class CharacterController : Controller
    {
        private CharacterContext db = new CharacterContext();

        private void PopulateAssignedVersionData(Character character)
        {

            var allVersion = db.CharacterVersions; var versionCharacterVersion = new HashSet<int>(character.CharacterVersion.Select(c => c.CharacterVersionID));
            var viewModel = new List<AssignedVersionData>();
            foreach (var version in allVersion)
            {
                viewModel.Add(new AssignedVersionData
                { CharacterVersionID = version.CharacterVersionID, Version = version.Version, Assigned = versionCharacterVersion.Contains(version.CharacterVersionID) });
            }
            ViewBag.CharacterVersion = viewModel;
        }


        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.WeightSortParm = sortOrder == "Weight" ? "weight_desc" : "Weight";
            ViewBag.HeightSortParm = sortOrder == "Height" ? "height_desc" : "Height";

            if (searchString != null)
            {
                page = 1;
            }
            else {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var characters = from c in db.Characters
                           select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                characters = characters.Where(c => c.ComicName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    characters = characters.OrderByDescending(c => c.CharacterName);
                    break;
                case "Weight":
                    characters = characters.OrderBy(c => c.Weight);
                    break;
                case "weight_desc":
                    characters = characters.OrderByDescending(c => c.Weight);
                    break;
                case "Height":
                    characters = characters.OrderBy(c => c.Height);
                    break;
                case "height_desc":
                    characters = characters.OrderByDescending(c => c.Height);
                    break;

                default:
                    characters = characters.OrderBy(c => c.CharacterName);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(characters.ToPagedList(pageNumber, pageSize));
        }

        // GET: Characters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // GET: Characters/Create
        public ActionResult Create()
        {
            var character = new Character();
            character.CharacterVersion = new List<CharacterVersion>();
            PopulateAssignedVersionData(character);
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CharacterName,ReleaseDate,ComicName,Weight,Height,Description")] Character character)
        {
            if (ModelState.IsValid)
            {
                db.Characters.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(character);
        }

        // GET: Characters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CharacterName,ReleaseDate,ComicName,Weight,Height,Description")] Character character)
        {
            if (ModelState.IsValid)
            {
                db.Entry(character).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(character);
        }

        // GET: Characters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Characters.Find(id);
            db.Characters.Remove(character);
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

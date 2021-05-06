using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using APTeamFootball.Models;

namespace APTeamFootball.Controllers
{
    public class ManchesterUnitedPlayersController : Controller
    {
        private ManchesterUnitedPlayersContext db = new ManchesterUnitedPlayersContext();

        // GET: ManchesterUnitedPlayers
        public ActionResult Index()
        {
            return View(db.ManchesterUnitedPlayers.ToList());
        }

        // GET: ManchesterUnitedPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchesterUnitedPlayers manchesterUnitedPlayers = db.ManchesterUnitedPlayers.Find(id);
            if (manchesterUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchesterUnitedPlayers);
        }

        // GET: ManchesterUnitedPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManchesterUnitedPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManchesterUnitedPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ManchesterUnitedPlayers manchesterUnitedPlayers)
        {
            if (ModelState.IsValid)
            {
                db.ManchesterUnitedPlayers.Add(manchesterUnitedPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manchesterUnitedPlayers);
        }

        // GET: ManchesterUnitedPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchesterUnitedPlayers manchesterUnitedPlayers = db.ManchesterUnitedPlayers.Find(id);
            if (manchesterUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchesterUnitedPlayers);
        }

        // POST: ManchesterUnitedPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManchesterUnitedPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ManchesterUnitedPlayers manchesterUnitedPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manchesterUnitedPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manchesterUnitedPlayers);
        }

        // GET: ManchesterUnitedPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchesterUnitedPlayers manchesterUnitedPlayers = db.ManchesterUnitedPlayers.Find(id);
            if (manchesterUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchesterUnitedPlayers);
        }

        // POST: ManchesterUnitedPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManchesterUnitedPlayers manchesterUnitedPlayers = db.ManchesterUnitedPlayers.Find(id);
            db.ManchesterUnitedPlayers.Remove(manchesterUnitedPlayers);
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

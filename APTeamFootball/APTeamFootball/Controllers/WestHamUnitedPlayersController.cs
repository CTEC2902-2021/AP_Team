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
    public class WestHamUnitedPlayersController : Controller
    {
        private WestHamUnitedPlayersContext db = new WestHamUnitedPlayersContext();

        // GET: WestHamUnitedPlayers
        public ActionResult Index()
        {
            return View(db.WestHamUnitedPlayers.ToList());
        }

        // GET: WestHamUnitedPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WestHamUnitedPlayers westHamUnitedPlayers = db.WestHamUnitedPlayers.Find(id);
            if (westHamUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(westHamUnitedPlayers);
        }

        // GET: WestHamUnitedPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WestHamUnitedPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WestHamUnitedPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] WestHamUnitedPlayers westHamUnitedPlayers)
        {
            if (ModelState.IsValid)
            {
                db.WestHamUnitedPlayers.Add(westHamUnitedPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(westHamUnitedPlayers);
        }

        // GET: WestHamUnitedPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WestHamUnitedPlayers westHamUnitedPlayers = db.WestHamUnitedPlayers.Find(id);
            if (westHamUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(westHamUnitedPlayers);
        }

        // POST: WestHamUnitedPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WestHamUnitedPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] WestHamUnitedPlayers westHamUnitedPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(westHamUnitedPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(westHamUnitedPlayers);
        }

        // GET: WestHamUnitedPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WestHamUnitedPlayers westHamUnitedPlayers = db.WestHamUnitedPlayers.Find(id);
            if (westHamUnitedPlayers == null)
            {
                return HttpNotFound();
            }
            return View(westHamUnitedPlayers);
        }

        // POST: WestHamUnitedPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WestHamUnitedPlayers westHamUnitedPlayers = db.WestHamUnitedPlayers.Find(id);
            db.WestHamUnitedPlayers.Remove(westHamUnitedPlayers);
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

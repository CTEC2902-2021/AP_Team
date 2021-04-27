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
    public class ManchasterCityPlayersController : Controller
    {
        private ManchasterCityPlayersContext db = new ManchasterCityPlayersContext();

        // GET: ManchasterCityPlayers
        public ActionResult Index()
        {
            return View(db.ManchasterCityPlayers.ToList());
        }

        // GET: ManchasterCityPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchasterCityPlayers manchasterCityPlayers = db.ManchasterCityPlayers.Find(id);
            if (manchasterCityPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchasterCityPlayers);
        }

        // GET: ManchasterCityPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManchasterCityPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManchasterCityPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ManchasterCityPlayers manchasterCityPlayers)
        {
            if (ModelState.IsValid)
            {
                db.ManchasterCityPlayers.Add(manchasterCityPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manchasterCityPlayers);
        }

        // GET: ManchasterCityPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchasterCityPlayers manchasterCityPlayers = db.ManchasterCityPlayers.Find(id);
            if (manchasterCityPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchasterCityPlayers);
        }

        // POST: ManchasterCityPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManchasterCityPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ManchasterCityPlayers manchasterCityPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manchasterCityPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manchasterCityPlayers);
        }

        // GET: ManchasterCityPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManchasterCityPlayers manchasterCityPlayers = db.ManchasterCityPlayers.Find(id);
            if (manchasterCityPlayers == null)
            {
                return HttpNotFound();
            }
            return View(manchasterCityPlayers);
        }

        // POST: ManchasterCityPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManchasterCityPlayers manchasterCityPlayers = db.ManchasterCityPlayers.Find(id);
            db.ManchasterCityPlayers.Remove(manchasterCityPlayers);
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

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
    public class AstonVillaPlayersController : Controller
    {
        private AstonVillaPlayersContext db = new AstonVillaPlayersContext();

        // GET: AstonVillaPlayers
        public ActionResult Index()
        {
            return View(db.AstonVillaPlayers.ToList());
        }

        // GET: AstonVillaPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AstonVillaPlayers astonVillaPlayers = db.AstonVillaPlayers.Find(id);
            if (astonVillaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(astonVillaPlayers);
        }

        // GET: AstonVillaPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AstonVillaPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AstonVillaPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] AstonVillaPlayers astonVillaPlayers)
        {
            if (ModelState.IsValid)
            {
                db.AstonVillaPlayers.Add(astonVillaPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(astonVillaPlayers);
        }

        // GET: AstonVillaPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AstonVillaPlayers astonVillaPlayers = db.AstonVillaPlayers.Find(id);
            if (astonVillaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(astonVillaPlayers);
        }

        // POST: AstonVillaPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AstonVillaPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] AstonVillaPlayers astonVillaPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(astonVillaPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(astonVillaPlayers);
        }

        // GET: AstonVillaPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AstonVillaPlayers astonVillaPlayers = db.AstonVillaPlayers.Find(id);
            if (astonVillaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(astonVillaPlayers);
        }

        // POST: AstonVillaPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AstonVillaPlayers astonVillaPlayers = db.AstonVillaPlayers.Find(id);
            db.AstonVillaPlayers.Remove(astonVillaPlayers);
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

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
    public class LeicesterPlayersController : Controller
    {
        private LeicesterPlayersContext db = new LeicesterPlayersContext();

        // GET: LeicesterPlayers
        public ActionResult Index()
        {
            return View(db.LeicesterPlayers.ToList());
        }

        // GET: LeicesterPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeicesterPlayers leicesterPlayers = db.LeicesterPlayers.Find(id);
            if (leicesterPlayers == null)
            {
                return HttpNotFound();
            }
            return View(leicesterPlayers);
        }

        // GET: LeicesterPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeicesterPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeicesterPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] LeicesterPlayers leicesterPlayers)
        {
            if (ModelState.IsValid)
            {
                db.LeicesterPlayers.Add(leicesterPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leicesterPlayers);
        }

        // GET: LeicesterPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeicesterPlayers leicesterPlayers = db.LeicesterPlayers.Find(id);
            if (leicesterPlayers == null)
            {
                return HttpNotFound();
            }
            return View(leicesterPlayers);
        }

        // POST: LeicesterPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeicesterPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] LeicesterPlayers leicesterPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leicesterPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leicesterPlayers);
        }

        // GET: LeicesterPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeicesterPlayers leicesterPlayers = db.LeicesterPlayers.Find(id);
            if (leicesterPlayers == null)
            {
                return HttpNotFound();
            }
            return View(leicesterPlayers);
        }

        // POST: LeicesterPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeicesterPlayers leicesterPlayers = db.LeicesterPlayers.Find(id);
            db.LeicesterPlayers.Remove(leicesterPlayers);
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

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
    public class EvertonPlayersController : Controller
    {
        private EvertonPlayersContext db = new EvertonPlayersContext();

        // GET: EvertonPlayers
        public ActionResult Index()
        {
            return View(db.EvertonPlayers.ToList());
        }

        // GET: EvertonPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvertonPlayers evertonPlayers = db.EvertonPlayers.Find(id);
            if (evertonPlayers == null)
            {
                return HttpNotFound();
            }
            return View(evertonPlayers);
        }

        // GET: EvertonPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvertonPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvertonPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] EvertonPlayers evertonPlayers)
        {
            if (ModelState.IsValid)
            {
                db.EvertonPlayers.Add(evertonPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evertonPlayers);
        }

        // GET: EvertonPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvertonPlayers evertonPlayers = db.EvertonPlayers.Find(id);
            if (evertonPlayers == null)
            {
                return HttpNotFound();
            }
            return View(evertonPlayers);
        }

        // POST: EvertonPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvertonPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] EvertonPlayers evertonPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evertonPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evertonPlayers);
        }

        // GET: EvertonPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EvertonPlayers evertonPlayers = db.EvertonPlayers.Find(id);
            if (evertonPlayers == null)
            {
                return HttpNotFound();
            }
            return View(evertonPlayers);
        }

        // POST: EvertonPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EvertonPlayers evertonPlayers = db.EvertonPlayers.Find(id);
            db.EvertonPlayers.Remove(evertonPlayers);
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

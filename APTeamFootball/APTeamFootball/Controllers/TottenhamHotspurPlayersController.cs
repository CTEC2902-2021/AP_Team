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
    public class TottenhamHotspurPlayersController : Controller
    {
        private TottenhamHotspurPlayersContext db = new TottenhamHotspurPlayersContext();

        // GET: TottenhamHotspurPlayers
        public ActionResult Index()
        {
            return View(db.TottenhamHotspurPlayers.ToList());
        }

        // GET: TottenhamHotspurPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TottenhamHotspurPlayers tottenhamHotspurPlayers = db.TottenhamHotspurPlayers.Find(id);
            if (tottenhamHotspurPlayers == null)
            {
                return HttpNotFound();
            }
            return View(tottenhamHotspurPlayers);
        }

        // GET: TottenhamHotspurPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TottenhamHotspurPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TottenhamHotspurPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] TottenhamHotspurPlayers tottenhamHotspurPlayers)
        {
            if (ModelState.IsValid)
            {
                db.TottenhamHotspurPlayers.Add(tottenhamHotspurPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tottenhamHotspurPlayers);
        }

        // GET: TottenhamHotspurPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TottenhamHotspurPlayers tottenhamHotspurPlayers = db.TottenhamHotspurPlayers.Find(id);
            if (tottenhamHotspurPlayers == null)
            {
                return HttpNotFound();
            }
            return View(tottenhamHotspurPlayers);
        }

        // POST: TottenhamHotspurPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TottenhamHotspurPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] TottenhamHotspurPlayers tottenhamHotspurPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tottenhamHotspurPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tottenhamHotspurPlayers);
        }

        // GET: TottenhamHotspurPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TottenhamHotspurPlayers tottenhamHotspurPlayers = db.TottenhamHotspurPlayers.Find(id);
            if (tottenhamHotspurPlayers == null)
            {
                return HttpNotFound();
            }
            return View(tottenhamHotspurPlayers);
        }

        // POST: TottenhamHotspurPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TottenhamHotspurPlayers tottenhamHotspurPlayers = db.TottenhamHotspurPlayers.Find(id);
            db.TottenhamHotspurPlayers.Remove(tottenhamHotspurPlayers);
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

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
    public class ChelseaPlayersController : Controller
    {
        private ChelseaPlayersContext db = new ChelseaPlayersContext();

        // GET: ChelseaPlayers
        public ActionResult Index()
        {
            return View(db.ChelseaPlayers.ToList());
        }

        // GET: ChelseaPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChelseaPlayers chelseaPlayers = db.ChelseaPlayers.Find(id);
            if (chelseaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(chelseaPlayers);
        }

        // GET: ChelseaPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChelseaPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChelseaPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ChelseaPlayers chelseaPlayers)
        {
            if (ModelState.IsValid)
            {
                db.ChelseaPlayers.Add(chelseaPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chelseaPlayers);
        }

        // GET: ChelseaPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChelseaPlayers chelseaPlayers = db.ChelseaPlayers.Find(id);
            if (chelseaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(chelseaPlayers);
        }

        // POST: ChelseaPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ChelseaPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] ChelseaPlayers chelseaPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chelseaPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chelseaPlayers);
        }

        // GET: ChelseaPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChelseaPlayers chelseaPlayers = db.ChelseaPlayers.Find(id);
            if (chelseaPlayers == null)
            {
                return HttpNotFound();
            }
            return View(chelseaPlayers);
        }

        // POST: ChelseaPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChelseaPlayers chelseaPlayers = db.ChelseaPlayers.Find(id);
            db.ChelseaPlayers.Remove(chelseaPlayers);
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

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
    public class LiverpoolPlayersController : Controller
    {
        private LiverpoolPlayersContext db = new LiverpoolPlayersContext();

        // GET: LiverpoolPlayers
        public ActionResult Index()
        {
            return View(db.LiverpoolPlayers.ToList());
        }

        // GET: LiverpoolPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LiverpoolPlayers liverpoolPlayers = db.LiverpoolPlayers.Find(id);
            if (liverpoolPlayers == null)
            {
                return HttpNotFound();
            }
            return View(liverpoolPlayers);
        }

        // GET: LiverpoolPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LiverpoolPlayers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LiverpoolPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] LiverpoolPlayers liverpoolPlayers)
        {
            if (ModelState.IsValid)
            {
                db.LiverpoolPlayers.Add(liverpoolPlayers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(liverpoolPlayers);
        }

        // GET: LiverpoolPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LiverpoolPlayers liverpoolPlayers = db.LiverpoolPlayers.Find(id);
            if (liverpoolPlayers == null)
            {
                return HttpNotFound();
            }
            return View(liverpoolPlayers);
        }

        // POST: LiverpoolPlayers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LiverpoolPlayersId,Appearances,Comments,DOB,Goals,Name,Number,Position")] LiverpoolPlayers liverpoolPlayers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(liverpoolPlayers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(liverpoolPlayers);
        }

        // GET: LiverpoolPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LiverpoolPlayers liverpoolPlayers = db.LiverpoolPlayers.Find(id);
            if (liverpoolPlayers == null)
            {
                return HttpNotFound();
            }
            return View(liverpoolPlayers);
        }

        // POST: LiverpoolPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LiverpoolPlayers liverpoolPlayers = db.LiverpoolPlayers.Find(id);
            db.LiverpoolPlayers.Remove(liverpoolPlayers);
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

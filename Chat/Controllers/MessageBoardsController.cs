using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chat;
using Microsoft.AspNet.Identity;

namespace Chat.Models
{
    public class MessageBoardsController : Controller
    {
        private OpenComsEntities db = new OpenComsEntities();

        // GET: MessageBoards
        public ActionResult Index()
        {
            ViewBag.LoggedInUser = User.Identity.GetUserName();
            return View(db.MessageBoards.ToList());
        }

        public ActionResult Chat()
        {
            return View(db.MessageBoards.ToList());
        }

        // GET: MessageBoards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageBoard = db.MessageBoards.Find(id);
            if (messageBoard == null)
            {
                return HttpNotFound();
            }
            return View(messageBoard);
        }

        // GET: MessageBoards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageBoards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RID,Username,Message,DateTimeOfMessage")] MessageBoard messageBoard)
        {
            if (ModelState.IsValid)
            {
                db.MessageBoards.Add(messageBoard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(messageBoard);
        }

        // GET: MessageBoards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageBoard = db.MessageBoards.Find(id);
            if (messageBoard == null)
            {
                return HttpNotFound();
            }
            return View(messageBoard);
        }

        // POST: MessageBoards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RID,Username,Message,DateTimeOfMessage")] MessageBoard messageBoard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(messageBoard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(messageBoard);
        }

        // GET: MessageBoards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageBoard messageBoard = db.MessageBoards.Find(id);
            if (messageBoard == null)
            {
                return HttpNotFound();
            }
            return View(messageBoard);
        }

        // POST: MessageBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MessageBoard messageBoard = db.MessageBoards.Find(id);
            db.MessageBoards.Remove(messageBoard);
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

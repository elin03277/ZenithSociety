﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;

namespace ZenithWebSite.Controllers
{
    public class ActivityCategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ActivityCategories
        public ActionResult Index()
        {
            return View(db.ActivityCategories.ToList());
        }

        // GET: ActivityCategories/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityCategory activityCategory = db.ActivityCategories.Find(id);
            if (activityCategory == null)
            {
                return HttpNotFound();
            }
            return View(activityCategory);
        }

        // GET: ActivityCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActivityCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActiveCategoryId,ActivityDescription,CreationDate")] ActivityCategory activityCategory)
        {
            if (ModelState.IsValid)
            {
                db.ActivityCategories.Add(activityCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activityCategory);
        }

        // GET: ActivityCategories/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityCategory activityCategory = db.ActivityCategories.Find(id);
            if (activityCategory == null)
            {
                return HttpNotFound();
            }
            return View(activityCategory);
        }

        // POST: ActivityCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActiveCategoryId,ActivityDescription,CreationDate")] ActivityCategory activityCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activityCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activityCategory);
        }

        // GET: ActivityCategories/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivityCategory activityCategory = db.ActivityCategories.Find(id);
            if (activityCategory == null)
            {
                return HttpNotFound();
            }
            return View(activityCategory);
        }

        // POST: ActivityCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ActivityCategory activityCategory = db.ActivityCategories.Find(id);
            db.ActivityCategories.Remove(activityCategory);
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
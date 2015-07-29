﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dealship_App.Models;

namespace Dealship_App.Controllers
{
    public class VehiclesController : Controller
    {
        private VehicleDBContext db = new VehicleDBContext();

        // GET: Vehicles

        public ActionResult Index(string make)
        {
            var makeList = new List<string>();
            var carsQry = from k in db.Vehicle
                          orderby k.Make
                          select k.Make;

            makeList.AddRange(carsQry.Distinct());
            ViewBag.make = new SelectList(makeList);

            var cars = from c in db.Vehicle
                       select c;


            if (!String.IsNullOrEmpty(make))
            {
                cars = cars.Where(x => x.Make == make);
            }

            return View(cars);
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicle.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            return View(vehicles);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Year,Make,Model,Color,MPG,MSRP,Image")] Vehicles vehicles)
        {
            if (ModelState.IsValid)
            {
                db.Vehicle.Add(vehicles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicles);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicle.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            return View(vehicles);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Year,Make,Model,Color,MPG,MSRP,Image")] Vehicles vehicles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicles);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicle.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            return View(vehicles);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicles vehicles = db.Vehicle.Find(id);
            db.Vehicle.Remove(vehicles);
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

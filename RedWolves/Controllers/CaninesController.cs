using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RedWolves.Models;

namespace RedWolves.Controllers
{
    public class CaninesController : Controller

    {
      

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Canines
        public async Task<ActionResult> Index()
        {
            return View(await db.Canines.ToListAsync());
        }

        // GET: Canines/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canines canines = await db.Canines.FindAsync(id);
            if (canines == null)
            {
                return HttpNotFound();
            }
            return View(canines);
        }

        // GET: Canines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Canines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "canineID,canineName,description")] Canines canines)
        {
            if (ModelState.IsValid)
            {
                db.Canines.Add(canines);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(canines);
        }

        // GET: Canines/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canines canines = await db.Canines.FindAsync(id);
            if (canines == null)
            {
                return HttpNotFound();
            }
            return View(canines);
        }

        // POST: Canines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "canineID,canineName,description")] Canines canines)
        {
            if (ModelState.IsValid)
            {
                db.Entry(canines).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(canines);
        }

        // GET: Canines/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canines canines = await db.Canines.FindAsync(id);
            if (canines == null)
            {
                return HttpNotFound();
            }
            return View(canines);
        }

        // POST: Canines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Canines canines = await db.Canines.FindAsync(id);
            db.Canines.Remove(canines);
            await db.SaveChangesAsync();
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

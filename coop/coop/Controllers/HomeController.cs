using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using coop.Models;

namespace coop.Controllers
{
    public class HomeController : Controller
    {
        coopEntities2 db = new coopEntities2();
        private object mb;


        // GET: andy Home 
        public ActionResult Index()
        {
            var query = from o in db.members
                        select o;
            return View(query.ToList());
        }


        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            member member = db.members.Find(id);
            //if (member == null)
            //{
            //    return HttpNotFound();
            //}
            return View(member);
        }

        // POST: members/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "personId,name,city")] member member)
        {
            //if (ModelState.IsValid)
            //{
            db.Entry(member).State = EntityState.Modified;
            db.SaveChanges();
                return RedirectToAction("Index");
            //}

            //return View(member);

        }






    }
}
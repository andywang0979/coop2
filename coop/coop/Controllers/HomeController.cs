using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coop.Models;

namespace coop.Controllers
{
    public class HomeController : Controller
    {
        coopEntities2 db = new coopEntities2();
        

        // GET: andy Home 
        public ActionResult Index()
        {
            var query = from o in db.members
                        select o;
            return View(query.ToList());
        }
    }
}
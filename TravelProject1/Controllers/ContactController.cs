using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject1.Models.Classlar;

namespace TravelProject1.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        TravelDbContext db = new TravelDbContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact con)
        {
            db.Contacts.Add(con);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
	}
}
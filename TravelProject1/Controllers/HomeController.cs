using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject1.Models.Classlar;

namespace TravelProject1.Controllers
{
    public class HomeController : Controller
    {
        TravelDbContext db = new TravelDbContext();
        public ActionResult Index()
        {
            var model = db.Blogs.ToList();
            return View(model);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var LeftBot = db.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(LeftBot);
        }
        public PartialViewResult Partial2()
        {
            var RightBot = db.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(RightBot);
        }
        public PartialViewResult Partial3()
        {
            var model = db.Blogs.Take(10).ToList();
            return PartialView(model);
        }
        public PartialViewResult Partial4()
        {
            var model = db.Blogs.Take(3).ToList();
            return PartialView(model);
        }
        public PartialViewResult Partial5()
        {
            var model = db.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            return PartialView(model);
        }
	}
}
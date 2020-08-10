using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject1.Models.Classlar;

namespace TravelProject1.Controllers
{
    public class AboutController : Controller
    {
        TravelDbContext db=new TravelDbContext();
        public ActionResult Index()
        {
            var model=db.Haqqimizdas.ToList();
            return View(model);
        }
	}
}
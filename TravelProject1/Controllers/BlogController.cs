using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject1.Models.Classlar;

namespace TravelProject1.Controllers
{
    public class BlogController : Controller
    {
        TravelDbContext db = new TravelDbContext();
        BlogComent bc = new BlogComent();

        public ActionResult Index()
        {
            bc.Blog1 = db.Blogs.ToList();
            bc.SonBlog = db.Blogs.Take(2).ToList();
            return View(bc);
        }
        public ActionResult BlogProperties(int id)
        {
            //var blog = db.Blogs.Where(x => x.Id == id).ToList();
            bc.Blog1 = db.Blogs.Where(x => x.Id == id).ToList();
            bc.Comment1 = db.Comments.Where(x => x.Blogid == id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult ReyYaz(int id)
        {
            ViewBag.GetId = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ReyYaz(Comment Rey)
        {
            db.Comments.Add(Rey);
            db.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult Contact(int id)
        {
            ViewBag.Getd = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(Contact Con)
        {
            db.Contacts.Add(Con);
                db.SaveChanges();
            return PartialView();
        }

	}
}
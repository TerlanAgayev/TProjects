using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject1.Models.Classlar;
namespace TravelProject1.Controllers
{
    public class AdminController : Controller
    {

        TravelDbContext db = new TravelDbContext();
  
        [Authorize]
        public ActionResult Index()
        {
            var model = db.Blogs.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog bmodel)
        {
            db.Blogs.Add(bmodel);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }
        public ActionResult BlogSil(int id)
        {
            var model = db.Blogs.Find(id);
            db.Blogs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var Bmodel = db.Blogs.Find(id);
            return View("GetBlog",Bmodel);
        }
        public ActionResult UpdateBlog(Blog B)
        {
            var blg = db.Blogs.Find(B.Id);
            blg.Basliq = B.Basliq;
            blg.Aciqlama = B.Aciqlama;
            blg.BlogImg = B.BlogImg;
            blg.Tarix = B.Tarix;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Comment()
        {
            var com = db.Comments.ToList();
            return View(com);
        }
        public ActionResult CommentSil(int id)
        {
            var model = db.Comments.Find(id);
            db.Comments.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Comment");
        }
        public ActionResult GetComent(int id)
        {
            var cmnt = db.Comments.Find(id);
            return View("GetComent",cmnt);
        }
        public ActionResult UpdateComent(Comment Rey)
        {
            var cmnt = db.Comments.Find(Rey.Id);
            cmnt.IstifadeciAd = Rey.IstifadeciAd;
            cmnt.Mail = Rey.Mail;
            cmnt.CommentString = Rey.CommentString;
            db.SaveChanges();
            return RedirectToAction("Comment");
        }
        public ActionResult ContactUser()
        {
            var cmodel = db.Contacts.ToList();
            return View(cmodel);
        }
	}
}
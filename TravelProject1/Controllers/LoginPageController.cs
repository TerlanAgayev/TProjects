using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelProject1.Models.Classlar;
namespace TravelProject1.Controllers
{
    public class LoginPageController : Controller
    {
        //
        // GET: /LoginPage/
        TravelDbContext db = new TravelDbContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var model = db.Admins.FirstOrDefault(x => x.Istifadeci == admin.Istifadeci && x.Parol == admin.Parol);
            if (model != null)
            {
                FormsAuthentication.SetAuthCookie(model.Istifadeci, false);
                Session["Istifadeci"] = model.Istifadeci.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "LoginPage");
        }
	}
}
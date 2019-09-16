using JooleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleWeb.Controllers
{
    public class HomeController : Controller
    {//
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult login()
        {
            User user = new User();
            //user.UserName = "Paul changed";
            return View("login",user);
           
        }
        [HttpPost]
        public ActionResult Authorize(JooleWeb.Models.User userModel)
        {
            using (Joole_RBBTEntities db=new Joole_RBBTEntities())
            {
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong user name or password";
                    return View("login", userModel);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["userName"] = userDetails.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        public ActionResult logOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("login", "HomeController");

        }

    }
}
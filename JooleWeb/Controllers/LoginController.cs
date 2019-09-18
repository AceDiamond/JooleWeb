using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using JooleWeb.SEV;

namespace JooleWeb.Controllers
{
    public class loginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {
            if(UserName == null || Password == null)
            {
                return View("index");
            }
            else
            {
                JooleWeb.SEV.Service LoginService = new JooleWeb.SEV.Service();
                int Authirize = LoginService.login(UserName, Password);
                if(Authirize == 1)
                {
                    Session["userName"] = UserName;
                    return RedirectToAction("Index", "Search");
                }
                else if(Authirize ==2)
                {
                    string message = "Your password is not correct.";
                    MessageBox.Show(message);
                    return View("index");
                }
                else if(Authirize == 3)
                {
                    string message = "Your user name is not correct.";
                    MessageBox.Show(message);
                    return View("index");
                }
                else
                {
                    return View("index");
                }
            }
            

        }
    }
}
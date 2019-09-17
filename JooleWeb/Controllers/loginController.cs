using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWeb.SEV;

namespace JooleWeb.Controllers
{
    public class LoginController : Controller
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
                bool Authirize = LoginService.login(UserName, Password);
                if(Authirize == true)
                {
                    return RedirectToAction("Search", "Search");
                }
                else
                {
                    return View("index");
                }

            }
            

        }
    }
}
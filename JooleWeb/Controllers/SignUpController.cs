using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleWeb.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Create(string UserName, string phone, string Email, string Password, string ConfirmPassword, string Credentials)
        {   
            if(Password != ConfirmPassword)
            {
                return View();//message "the Password does not match!"
            }
            else
            {
                JooleWeb.SEV.Service SignUpService = new JooleWeb.SEV.Service();
                bool Success = SignUpService.SignUp(UserName, phone, Email, Password, Credentials);
                if(Success == true)
                {
                    return RedirectToAction("Search", "Search");
                }
                else
                {
                    return View("Index");
                }
            }
        }
     
    }
}
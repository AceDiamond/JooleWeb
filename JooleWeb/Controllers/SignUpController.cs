using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
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
        [HttpPost]
        public ActionResult Create(string UserName, string phone, string Email, string Password, string ConfirmPassword, string Credentials)
        {   
            if(Password != ConfirmPassword)
            {
                string message = "the Password does not match!";
                MessageBox.Show(message);
                return View("Index");
            }
            else
            {
                JooleWeb.SEV.Service SignUpService = new JooleWeb.SEV.Service();
                int Success = SignUpService.SignUp(UserName, phone, Email, Password, Credentials);
                if(Success == 2)
                {
                    string message = "Your have successfully signed up!";
                    MessageBox.Show(message);
                    return RedirectToAction("Login", "Index");
                }
                else if(Success == 1)
                {
                    string message = "This user name has already exist!";
                    MessageBox.Show(message);
                    return View("Index");
                }
                else if (Success == 3)
                {
                    string message = "the phone number or email has been used!";
                    MessageBox.Show(message);
                    return View("Index");
                }
                else
                {
                    string message = "please choose your Credentials!";
                    MessageBox.Show(message);
                    return View("Index");
                }
            }
        }
     
    }
}
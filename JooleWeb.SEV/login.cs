using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleWeb.SEV
{
    class login
    {
        private readonly object user;

        public User User { get; private set; }

        public login()
        {
            User = new User();
            //user.UserName = "Paul changed";
            return View("login", user);

        }

        private void View(string v, object user)
        {
            throw new NotImplementedException();
        }

        private void View(string v, User user)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Authorize(JooleWeb.Models.User userModel)
        {
            using (Joole_RBBTEntities db = new Joole_RBBTEntities())
            {
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
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

    internal class User
    {
        public User()
        {
        }
    }
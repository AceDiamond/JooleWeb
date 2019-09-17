using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb.DAL;
using JooleWeb.Repo;

namespace JooleWeb.SEV
{
   public partial class Service
    {
        public bool login(string UserName, string Password)
        {
            bool UserLogIn;
            UserLogIn = false;
            foreach(User UserData in uow.user.GetAll().ToList())
            {
                if(UserName == UserData.UserName)
                {
                   if(Password == UserData.Password)
                    {
                        UserLogIn = true;
                        break;
                    }
                    else
                    {
                        UserLogIn = false;
                    }
                }
                else
                {
                    UserLogIn = false;
                }
            }
            
            return UserLogIn;
        }

    }
}

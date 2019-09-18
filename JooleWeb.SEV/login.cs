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
        public int login(string UserName, string Password)
        {
            int UserLogIn;
            UserLogIn = 0;
            foreach(User UserData in uow.user.GetAll().ToList())
            {
                if(UserName == UserData.UserName)
                {
                   if(Password == UserData.Password)
                    {
                        UserLogIn = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your user name does not exist");
                        UserLogIn = 2;
                    }
                }
                else
                {
                    Console.WriteLine("Your user name does not exist");
                    UserLogIn = 3;
                }
            }
            
            return UserLogIn;
        }

    }
}

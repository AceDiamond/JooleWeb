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
        public int SignUp(string UserName, string phone, string Email, string Password, string Credentials)
        {
            int Regiester;
            Regiester = 0;
            User inputUser = new User();
            inputUser.UserName = UserName;
            inputUser.Password = Password;
            foreach (User userData in uow.user.GetAll().ToList())
            {
                if (UserName == userData.UserName)
                {
                    Console.WriteLine("This user name has already exist");
                    Regiester = 1; //content("The user name has already exist");
                    break;
                }
                else
                {
                     Regiester = 2;
                }
            }

            if (Regiester == 2)
            {
                if (Credentials == "Customer")
                {
                    foreach (Customer customerData in uow.customer.GetAll().ToList())
                    {
                        if (phone == customerData.phone || Email == customerData.Email)
                        {
                            Console.WriteLine("the phone number or email has been used");
                            Regiester = 3;
                            break;
                        }
                        else
                        {
                            Credentials = "1";
                            int parseCredentials = int.Parse(Credentials);
                            inputUser.Credentials = parseCredentials;
                            uow.user.Add(inputUser);
                            Customer inputCustomer = new Customer();
                            inputCustomer.Email = Email;
                            inputCustomer.phone = phone;
                            uow.customer.Add(inputCustomer);
                            uow.SaveChanges();
                            Regiester = 2;
                            break;
                        }
                    }
                }
                else if (Credentials == "Consumer")
                {
                    foreach (Consumer ConsumerData in uow.consumer.GetAll().ToList())
                    {
                        if (phone == ConsumerData.phone || Email == ConsumerData.Email)
                        {
                            Console.WriteLine("the phone number or email has been used");
                            Regiester = 3;
                            break;
                        }
                        else
                        {
                            Credentials = "2";
                            int parseCredentials = int.Parse(Credentials);
                            inputUser.Credentials = parseCredentials;
                            uow.user.Add(inputUser);
                            uow.SaveChanges();
                            Consumer inputConsumer = new Consumer();
                            inputConsumer.Email = Email;
                            inputConsumer.phone = phone;
                            uow.consumer.Add(inputConsumer);
                            uow.SaveChanges();
                            Regiester = 2;
                            break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("please choose your Credentials");
                    Regiester = 4;
                }

             }
            return Regiester;

        }
    }
}

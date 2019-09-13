using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

namespace JooleWeb.Repo
{
    public interface ICustomer :IRepository<Customer>
    {
    }

    public class CustomerRepo : Repository<Customer>, ICustomer
    {
        public CustomerRepo(DbContext context) : base(context)
        {

        }
    }
}

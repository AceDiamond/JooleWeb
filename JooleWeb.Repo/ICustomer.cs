using System.Data.Entity;
using JooleWeb.DAL;

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

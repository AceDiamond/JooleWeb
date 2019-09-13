using JooleWeb.DAL;
using System.Data.Entity;

namespace JooleWeb.Repo
{

  public   interface IUSersRepo : IRepository<User>
    {

    }
    internal class UserRepo : Repository<User>,IUSersRepo
    {
        private DbContext context;

        public  UserRepo(DbContext context) : base (context)
        {
            this.context = context;
        }
    }
}
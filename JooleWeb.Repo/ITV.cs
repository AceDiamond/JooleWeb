using JooleWeb.DAL;
using System.Data.Entity;

namespace JooleWeb.Repo
{
    public interface ITV : IRepository<TV>
    {

    }

    public class TVRepo : Repository<TV>, ITV
    {
        public TVRepo(DbContext context ) :base(context)
        {

        }
    }

}

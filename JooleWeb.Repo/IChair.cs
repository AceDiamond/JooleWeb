using System.Data.Entity;
using JooleWeb.DAL;

namespace JooleWeb.Repo
{
    public interface IChair : IRepository<Chair>
    {
    }

    public class ChairRepo : Repository<Chair>, IChair
    {
        public ChairRepo(DbContext context) : base(context)
        {

        }
    }
}

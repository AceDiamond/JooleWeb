using JooleWeb.DAL;
using System.Data.Entity;

namespace JooleWeb.Repo
{
    public interface IHomeTheater :IRepository<HomeTheater>
    {
    }

    public class HomeTheaterRepo : Repository<HomeTheater>, IHomeTheater
    {
        public HomeTheaterRepo(DbContext context) : base(context)
        {

        }
    }
}

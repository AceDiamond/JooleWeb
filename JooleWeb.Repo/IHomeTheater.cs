using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

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

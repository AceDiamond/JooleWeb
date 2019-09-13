using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb_DAL;
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

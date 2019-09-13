using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

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

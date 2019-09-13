using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb_DAL;
using System.Data.Entity;

namespace JooleWeb.Repo
{
    public interface ITable :IRepository<Table>
    {

    }

    public class TableRepo : Repository<Table>, ITable
    {
        public TableRepo(DbContext context) : base(context)
        {

        }

    }
}

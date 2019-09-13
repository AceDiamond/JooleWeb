using JooleWeb.DAL;
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

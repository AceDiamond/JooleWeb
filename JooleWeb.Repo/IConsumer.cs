using System.Data.Entity;
using JooleWeb.DAL;

namespace JooleWeb.Repo
{
    public interface IConsumer : IRepository<Consumer>
    {
    }

    public class ConsumerRepo :Repository<Consumer>, IConsumer
    {
        public ConsumerRepo(DbContext context) : base(context)
        {

        }
    }
}

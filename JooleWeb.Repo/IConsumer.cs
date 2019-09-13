using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

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

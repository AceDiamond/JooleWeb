using JooleWeb.Repo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb.DAL;

namespace JooleWeb.SEV
{
    public  partial class Service
    {

        public static readonly Joole_RBBTEntities context = new Joole_RBBTEntities();
        UnitOfWork uow = new UnitOfWork(context);
        protected readonly DbContext Context;
        public Service()
        {
            Context = context;
        }
    }
}

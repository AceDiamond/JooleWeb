using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

namespace JooleWeb.Repo
{
    public interface IProduct :IRepository<Product>
    {
    }

    public class ProductRepo: Repository<Product>, IProduct
    {
        public ProductRepo(DbContext context) :base(context)
        {

        }

    }
}

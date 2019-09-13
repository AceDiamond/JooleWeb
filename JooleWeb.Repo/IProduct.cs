using JooleWeb.DAL;
using System.Data.Entity;

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

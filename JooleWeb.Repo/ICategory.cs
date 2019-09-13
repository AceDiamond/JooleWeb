using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

namespace JooleWeb.Repo
{
    public interface ICategory : IRepository<Category>
    {
    }

    public class CategoryRepo : Repository<Category>, ICategory
    {
        public CategoryRepo(DbContext context) : base(context)
        {

        }
    }
}

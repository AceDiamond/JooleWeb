using JooleWeb.DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace JooleWeb.Repo
{
    public interface ISubCategory : IRepository<SubCategory>
    {
        IEnumerable<SubCategory> getSubCategoBasedOnCatego(int categoryID);
    }

    public class SubCategoryRepo : Repository<SubCategory>, ISubCategory
    {
        DbContext Context;
        public SubCategoryRepo(DbContext context) : base(context)
        {
            this.Context = context;
        }

        public IEnumerable <SubCategory> getSubCategoBasedOnCatego(int categoryID)
        {
            return Context.Set<SubCategory>().ToList().Where(p => p.CategoryID == categoryID);
        }
    }
}


using JooleWeb.DAL;
using System.Data.Entity;

namespace JooleWeb.Repo
{
    public interface ISubCategory : IRepository<SubCategory>
    {
    }

    public class SubCategoryRepo : Repository<SubCategory>, ISubCategory
    {
        public SubCategoryRepo(DbContext context) : base(context)
        {

        }
    }
}


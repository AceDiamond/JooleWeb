using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JooleWeb_DAL;

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


using System.Data.Entity;
using JooleWeb.DAL;
using System;
using System.Collections.Generic;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb.Repo;
using System.Data.Entity;
using JooleWeb.DAL;

namespace JooleWeb.SEV
{
    public class SearchServices
    {
        public static readonly  Joole_RBBTEntities context = new Joole_RBBTEntities();

        UnitOfWork uow = new UnitOfWork(context);

        public List<DAL.Category> GetCategories()
        {
            return uow.category.GetAll().ToList();
        }
        public List<DAL.SubCategory> GetSubCategories(int categoryID)
        {
            return uow.subCategory.getSubCategoBasedOnCatego(categoryID).ToList();
        }
    }
}

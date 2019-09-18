using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleWeb.SEV
{
    public partial class Service
    {

        public List<DAL.Category> GetCategories()
        {
            return uow.category.GetAll().ToList();
        }
        public List<DAL.SubCategory> GetSubCategories(int categoryID)
        {
            return uow.subCategory.getSubCategoBasedOnCatego(categoryID).ToList();
        }
        public List<DAL.SubCategory> GetAllSub()
        {
            return uow.subCategory.GetAll().ToList();
        }
    }
}

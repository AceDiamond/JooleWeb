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
    public partial class Service
    {
        public Product getProductObj(int id)
        {
            Product product = uow.product.GetByID(id);
            return product;

        }
        public string getProductPrice(int id)
        {
            return uow.product.GetByID(id).Price.ToString();
        }
        public string getProductDescription(int id)
        {
            return uow.product.GetByID(id).Description.ToString();
        }
    }
}

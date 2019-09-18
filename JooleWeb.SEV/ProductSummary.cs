using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleWeb.DAL;
using JooleWeb.Repo;

namespace JooleWeb.SEV
{
    public partial class Service
    {
        public List<Product> AllSummary()
            {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
                foreach (var item in products)
                {
                    Product prod = new Product();
                    prod.ProductID = item.ProductID;
                    prod.ProductsName = item.ProductsName;
                    prod.CategoryID = item.CategoryID;
                    prod.Price = item.Price;
                    prod.SubcategoryID = item.SubcategoryID;
                    prod.ProductImage = item.ProductImage;
                    prod.Description = item.Description;
                    productlist.Add(prod);
                }
            return productlist;
        }

            


    }
}
   

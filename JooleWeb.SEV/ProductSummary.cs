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


        public List<Product> ElecSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if(item.CategoryID == 1)
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
               
            }
            return productlist;
        }


        public List<Product> FurnSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryID == 2)
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

            }
            return productlist;
        }

        public List<Product> TVSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryID == 1 && item.SubcategoryID == 1)
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

            }
            return productlist;
        }

        public List<Product> HomeSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryID == 1 && item.SubcategoryID == 2 )
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

            }
            return productlist;
        }

        public List<Product> TableSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryID == 2 && item.SubcategoryID == 4)
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

            }
            return productlist;
        }


        public List<Product> ChairSummary()
        {
            List<Product> products = new List<Product>();
            products = uow.product.GetAll().ToList();
            List<Product> productlist = new List<Product>();
            foreach (var item in products)
            {
                if (item.CategoryID == 2 && item.SubcategoryID == 3)
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

            }
            return productlist;
        }
    }
}
   

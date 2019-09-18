using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWeb.Models;
using JooleWeb.SEV;
using JooleWeb.DAL;

namespace JooleWeb.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        public ActionResult Summary()
        {

            

            JooleWeb.SEV.Service ProductSummary = new JooleWeb.SEV.Service();
            List<Product> products = ProductSummary.AllSummary();
            var productList = new List<Summary>();


            foreach(var item in products)
            {
                var productItem = new Summary();
                productItem.productName = item.ProductsName;
                productItem.Category = item.CategoryID.ToString();
                productItem.subcat = item.SubcategoryID.ToString();
                productItem.image = item.ProductImage;
                productItem.price = item.Price.ToString();
                productItem.desc = item.Description;
                productList.Add(productItem);
            }
            return View(productList);
        }
    }
}
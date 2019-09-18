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
        JooleWeb.SEV.Service ProductSummary = new JooleWeb.SEV.Service();
        List<Product> products;
        // GET: Summary
        public ActionResult Summary(string cat, string catSub)
        {


            switch (cat)
            {
                case "1":
                    switch(catSub)
                    {
                        case "1":
                            products = ProductSummary.TVSummary();
                            break;
                        case "2":
                            products = ProductSummary.HomeSummary();
                            break;
                        default:
                            products = ProductSummary.ElecSummary();
                            break;
                    }           
                    break;
                case "2":
                    switch (catSub)
                    {
                        case "3":
                            products = ProductSummary.ChairSummary();
                            break;
                        case "4":
                            products = ProductSummary.TableSummary();
                            break;
                        default:
                            products = ProductSummary.FurnSummary();
                            break;
                    }
                    break;

                default:
                    products = ProductSummary.AllSummary();
                    break;

            }


           
           
            var productList = new List<Summary>();


            foreach (var item in products)
            {
                var productItem = new Summary();
                productItem.productName = item.ProductsName;

                switch ((item.CategoryID))
                {
                    case 1:
                        productItem.Category = "Electronics";
                        break;
                    case 2:
                        productItem.Category = "Furniture";
                        break;

                    default:
                        productItem.Category = "Electronics";
                        break;
                }


                switch ((item.SubcategoryID))
                {
                    case 1:
                        productItem.subcat = "TV";
                        break;

                    case 2:
                        productItem.subcat = "Home Theater";
                        break;
                    case 3:
                        productItem.subcat = "Table";
                        break;
                    case 4:
                        productItem.subcat = "Chair";
                        break;
                }
                productItem.productID = item.ProductID;
                productItem.image = item.ProductImage;
                productItem.price = item.Price.ToString();
                productItem.desc = item.Description;
                productList.Add(productItem);

            }



            return View(productList);
        }
    }
}
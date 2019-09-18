using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWeb.SEV;
using JooleWeb.Models;

namespace JooleWeb.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult Index()
        {
            return View("ProductDetails");
        }

        public ActionResult showDetails(int id)
        {
            var newService = new Service();
            ProductDetails productdetails = new ProductDetails();
            productdetails.description = newService.getProductDescription(id);
            productdetails.price = newService.getProductPrice(id);
            productdetails.productSpec = newService.getProductSpec(id);
            productdetails.productName = newService.getProductName(id);
            return View("ProductDetails",productdetails);
        } 

    }
}
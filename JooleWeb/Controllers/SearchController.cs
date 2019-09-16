using JooleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWeb.SEV;

namespace JooleWeb.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        public ActionResult Index(int? value)
        {
            List<Category_M> listObj = new List<Category_M>();
            //foreach (var tempCatego in new JooleWeb.SEV.SearchServices().GetCategories())
            foreach (var tempCatego in new Service().GetCategories())
            {

                Category_M tempObj = new Category_M();
                tempObj.Category_ID = tempCatego.CategoryID;
                tempObj.Category_Name = tempCatego.CategoryName;
                listObj.Add(tempObj);

            }

            ViewBag.Category = new SelectList(listObj, "Category_ID", "Category_Name");

            if (value != null)
            {
                SubCategory_M tempSubCategory = new SubCategory_M();

                List<string> subCategoList = new List<string>();

                int val = (int)value;

                foreach (var temp in new Service().GetSubCategories(val))
                {
                    subCategoList.Add(temp.subCategoryName);
                }

                tempSubCategory.SubCategory_Name = subCategoList;
                ViewBag.subCategory = new SelectList(subCategoList);
            }
            return View();
        }


    }
}
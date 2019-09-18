using JooleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JooleWeb.SEV;
using Newtonsoft.Json;

namespace JooleWeb.Controllers
{
    [MyAuthorize]
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        public ActionResult Index(int? value)
        {
            List<Category_M> listObj = new List<Category_M>();

            foreach (var tempCatego in new Service().GetCategories())
            {

                Category_M tempObj = new Category_M();
                tempObj.Category_ID = tempCatego.CategoryID;
                tempObj.Category_Name = tempCatego.CategoryName;
                listObj.Add(tempObj);

            }
            ViewBag.Cate = listObj;
            ViewBag.current = value;
            //ViewBag.Category = new SelectList(listObj, "Category_ID", "Category_Name");

            if (value != null)
            {
                List<SubCategory_M> subCategoList = new List<SubCategory_M >();

                int val = (int)value;

                foreach (var temp in new Service().GetSubCategories(val))
                {
                    SubCategory_M tempSubCategory = new SubCategory_M();
                    tempSubCategory.SubCategory_Name = temp.subCategoryName;
                    tempSubCategory.SubCategory_ID = temp.subCategoryID;
                    subCategoList.Add(tempSubCategory);
                }
                ViewBag.subCategory = subCategoList;
                //ViewBag.subCategory = new SelectList(subCategoList, "SubCategory_ID", "SubCategory_Name");
            }
            else {

                List<SubCategory_M> subCategoList = new List<SubCategory_M>();

                foreach (var temp in new Service().GetAllSub())
                {
                    SubCategory_M tempSubCategory = new SubCategory_M();
                    tempSubCategory.SubCategory_Name = temp.subCategoryName;
                    tempSubCategory.SubCategory_ID = temp.subCategoryID;
                    subCategoList.Add(tempSubCategory);
                }
                ViewBag.subCategory = subCategoList;
                //ViewBag.subCategory = new SelectList(subCategoList, "SubCategory_ID", "SubCategory_Name");

            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string subCategory, string Category)
        {
            /*if (string.IsNullOrEmpty(subCategory))
            {
                return RedirectToAction("Summary", "Product", new { subCate = subCategory, cate = Category });

            }
            else
            {*/
                return RedirectToAction("Summary", "Summary", new { cat = Category, catSub = subCategory});
            //}
        }
    }
}
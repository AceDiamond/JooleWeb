using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleWeb.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View("Search");
        }

        public ActionResult LoadCategory()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            ViewData["Category"] = li;
            return View();
        }
    }
}
}
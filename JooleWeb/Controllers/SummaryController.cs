using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleWeb.Controllers
{
    public class SummaryController : Controller
    {
        // GET: Summary
        public ActionResult Index()
        {
            return View();
        }

        // GET: Summary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}

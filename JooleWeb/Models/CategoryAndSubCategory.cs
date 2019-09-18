using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JooleWeb.Models
{
    public class Category_M
    {
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        public List<string> SubCategory_ID { get; set; }

    }
    public class SubCategory_M
    {
        public int SubCategory_ID { get; set; }
        public string SubCategory_Name { get; set; }
    }
}
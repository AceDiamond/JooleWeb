using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JooleWeb.Models
{
    public class ProductDetails
    {
        public string price { get; set; }
        public string description { get; set; }
        public List<String> productSpec { get; set; }

        public string productName { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JooleWeb.Models
{
    public class login
    {   
        [DisplayName("User Name")]
        public string UserName { get; set;}
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}
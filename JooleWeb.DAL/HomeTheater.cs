//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JooleWeb.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HomeTheater
    {
        public int ProductID { get; set; }
        public int subCategoryID { get; set; }
        public string MaximumVideoResolution { get; set; }
        public Nullable<bool> SurroundSound { get; set; }
        public Nullable<decimal> NumberofChannels { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}

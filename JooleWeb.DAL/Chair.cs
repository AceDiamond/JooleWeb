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
    
    public partial class Chair
    {
        public int ProductID { get; set; }
        public int subCategoryID { get; set; }
        public Nullable<byte> ProductHeight { get; set; }
        public Nullable<byte> ProductWidth { get; set; }
        public string FrameMaterial { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}

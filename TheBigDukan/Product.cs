//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheBigDukan
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int product_ID { get; set; }
        public string product_Maker { get; set; }
        public string product_Name { get; set; }
        public int category_ID { get; set; }
        public int vendor_ID { get; set; }
        public int product_Quantity { get; set; }
        public string product_Type { get; set; }
        public string product_Detail { get; set; }
        public Nullable<bool> is_Active { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
        public string created_Date { get; set; }
        public string Update_Date { get; set; }
        public string created_By { get; set; }
        public string UpDate_By { get; set; }
        public Nullable<int> Discounted_Prize { get; set; }
    }
}

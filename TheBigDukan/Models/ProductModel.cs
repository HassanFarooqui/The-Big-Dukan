﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBigDukan.Models
{
    public class ProductModel
    {

        public int Product_ID { get; set; }

        public string Product_Name { get; set; }

        public int Product_Maker { get; set; }

        public int Cat_ID { get; set; }

        public int Vendor_ID { get; set; }

        public int Product_Quantity { get; set; }

        public int Product_Prize { get; set; }

        public int Product_Type { get; set; }

        public int Product_Details { get; set; }
    }
}
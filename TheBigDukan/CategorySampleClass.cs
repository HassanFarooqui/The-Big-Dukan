using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBigDukan
{
    public class CategorySampleClass
    {
       public int Id;
       public string Name;

        public static CategorySampleClass sharedVar = new CategorySampleClass();

       public CategorySampleClass()
        {
        }
        public CategorySampleClass(Main_Category main)
        {
            Id = main.category_ID;
            Name = main.cat_Data;
         }
    }
}
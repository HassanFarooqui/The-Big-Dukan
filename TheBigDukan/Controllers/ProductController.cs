using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;

namespace TheBigDukan.Controllers
{
    public class ProductController : Controller
    {
        Entities1 DB = new Entities1();

        [HttpGet]
        // GET: Product
        public ActionResult ProductAction()
        {
            int abc =  SignUpModel.sharedInstance.Id;
            string name = SignUpModel.sharedInstance.Name;
            string a = SignUpModel.sharedInstance.Password;

            return View();
        }
        [HttpPost]
        public ActionResult ProductAction(ProductModel myProductModel)
        {
            Product VendProd = new Product();
            try
            {
                VendProd.category_ID = 1;
                VendProd.product_Maker = "Samsung";
                VendProd.product_Name = "Note 6";
                VendProd.category_ID = 2;
                VendProd.vendor_ID = 3;
                VendProd.product_Quantity = 4;
                VendProd.product_Type = "A";
                VendProd.product_Detail = "Good";
                VendProd.is_Active = true;
                VendProd.Is_Deleted = false;
                VendProd.created_Date = "alkb";
                VendProd.Update_Date = "aj";
                VendProd.Discounted_Prize = 4;
          
            }
            catch (Exception )
            {
                throw;
               
            }
           
            return View();
        }
    }
}
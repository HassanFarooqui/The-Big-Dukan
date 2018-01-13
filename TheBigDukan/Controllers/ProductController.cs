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
        Main_Category Main_cat_Data;
        SignUpModel Vendor_Data;

      

        [HttpGet]
        // GET: Product
        public ActionResult ProductAction()
        {
            Vendor_Data = SignUpModel.sharedInstance;

            Main_cat_Data = (Main_Category)Session["CategoryOBj"];
           
          
            return View();
        }
        [HttpPost]
        public ActionResult ProductAction(ProductModel myProductModel)
        {
            Product ProdData = new Product();
            try
            {
                ProdData.category_ID = Main_cat_Data.category_ID;
                ProdData.product_Maker = myProductModel.Product_Maker;
                ProdData.product_Name = myProductModel.Product_Name;
                ProdData.vendor_ID = Vendor_Data.Id;
                ProdData.product_Quantity = myProductModel.Product_Quantity;
                ProdData.product_Type = myProductModel.Product_Type;
                ProdData.product_Detail = myProductModel.Product_Details;
                ProdData.is_Active = true;
                ProdData.Is_Deleted = false;
                ProdData.created_Date = Convert.ToString(DateTime.Now); ;
                ProdData.Update_Date = null;
                ProdData.Discounted_Prize = myProductModel.Product_Prize;
                ProdData.created_By = Vendor_Data.Email;
                ProdData.Update_Date = null;
             

            }
            catch (Exception )
            {
                throw;
               
            }
           
            return View();
        }
    }
}
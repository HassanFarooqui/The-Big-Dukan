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
           // Vendor_Data = SignUpModel.sharedInstance;

           // Main_cat_Data = (Main_Category)Session["CategoryOBj"];
           
          
            return View();
        }

      
        [HttpPost]
        public ActionResult ProductAction(ProductModel myProductModel)
        {
            ActionResult myAction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            Product ProdData = new Product();
            try
            {
                if (SignUpModel.sharedInstance == null || Session["CategoryOBj"] == null)
                {
                    return myAction;
                }
                Vendor_Data = SignUpModel.sharedInstance;
                Main_cat_Data = (Main_Category)Session["CategoryOBj"];
                ProdData.category_ID = Main_cat_Data.category_ID;
                ProdData.product_Maker = myProductModel.Product_Maker;
                ProdData.product_Name = myProductModel.Product_Name;
                ProdData.vendor_ID = Vendor_Data.Id;
                ProdData.product_Quantity = myProductModel.Product_Quantity;
                ProdData.product_Type = Main_cat_Data.cat_Data;
                ProdData.product_Detail = myProductModel.Product_Details;
                ProdData.is_Active = true;
                ProdData.Is_Deleted = false;
                ProdData.created_Date = Convert.ToString(DateTime.Now);
                ProdData.Update_Date = null;
                ProdData.Discounted_Prize = myProductModel.Product_Prize;
                ProdData.created_By = Vendor_Data.Email;
                ProdData.Update_Date = null;
                DB.Products.Add(ProdData);
                DB.SaveChanges();




            }
            catch (Exception ex )
            {
                Response.Write(ex.Message);
               
            }
           
            return View();
        }
    }
}
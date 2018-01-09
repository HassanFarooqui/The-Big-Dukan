using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;
namespace TheBigDukan.Controllers
{
    public class VendorController : Controller
    {
        Entities1 db = new Entities1();
        int category_id;


        // GET: Vendor
        public ActionResult VenderActionIndex(SignUpModel model)
        {
            SignUpModel.sharedInstance = model;
            return View(model);
        }
        public ActionResult Electronic()
        {
            ActionResult myaction = RedirectToAction("ProductAction", "Product");
            string Elect = "Electronics";

            //   Registration regform = db.Registrations.Single(w => w.email == id && w.password == pass);
            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.Cat_Name == Elect);
                if (maincat != null)
                {

                    category_id = maincat.category_ID;


                }
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
            


            return myaction;
        }
    }
}
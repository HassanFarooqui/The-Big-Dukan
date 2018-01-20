using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;

namespace TheBigDukan.Controllers
{
  
    public class ProductDetailController : Controller
    {

        Entities1 db = new Entities1();
        // GET: ProductDetail
        public ActionResult ProductDetailActionIndex()
        {
            return View(db.Products.ToList());
        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(g => g.product_ID == id);
            return View(p);
        }

        [HttpPost]
        public ActionResult EditProduct(Product model)
        {
            ActionResult myAction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch (Exception a)
            {

            }
            return myAction;
        }


     
        public ActionResult DetailProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(g => g.product_ID == id);
            return View(p);
        }
      



    }
}
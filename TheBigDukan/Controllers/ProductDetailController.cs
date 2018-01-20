using System;
using System.Collections.Generic;
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


        public ActionResult EditProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(g => g.product_ID == id);
            return View(p);
        }
    }
}
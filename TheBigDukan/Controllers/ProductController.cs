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
        
        // GET: Product
        public ActionResult ProductAction()
        {
           int abc =  SignUpModel.sharedInstance.Id;
            string name = SignUpModel.sharedInstance.Name;
            string a = SignUpModel.sharedInstance.Password;

            return View();
        }
    }
}
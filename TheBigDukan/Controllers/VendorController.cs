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
               
        // GET: Vendor
        public ActionResult VenderActionIndex(SignUpModel model)
        {
            SignUpModel.sharedInstance = model;
            return View(model);
        }
    }
}
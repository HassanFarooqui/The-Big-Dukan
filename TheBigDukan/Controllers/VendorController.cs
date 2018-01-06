using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheBigDukan.Controllers
{
    public class VendorController : Controller
    {
        // GET: Vendor
        public ActionResult VenderActionIndex(Models.SignUpModel model)
        {
            return View(model);
        }
    }
}
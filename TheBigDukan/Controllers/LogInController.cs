using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;

namespace TheBigDukan.Controllers
{
    public class LogInController : Controller
    {
        Entities db = new Entities();
        // GET: LogIn
        public ActionResult LogInAction()
        {
            return View();
        }
       [HttpGet]
      public ActionResult SignUpView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpView(SignUpModel mymodelSignUp)

        {
            Reg_Table regform = new Reg_Table();
            regform.name = mymodelSignUp.Name;
            regform.email = mymodelSignUp.Email;
            regform.address = mymodelSignUp.Address;
            regform.cellNo = Convert.ToString(mymodelSignUp.CellNo);
            



           
            return View();
        }
    }
}
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
        Entities1 db = new Entities1();
        // GET: LogIn
        [HttpGet]
        public ActionResult LogInAction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogInAction(LogInModel myLoginModel)

        {
            ActionResult myaction = RedirectToAction("VenderActionIndex", "Vendor");
            string id = myLoginModel.Email;
            string pass = myLoginModel.Password;
            try
            {
                Registration regform = db.Registrations.Single(w => w.email == id && w.password == pass);
                if (ModelState.IsValid)
                {
                    if (regform == null)
                    {
                       
                        myLoginModel.ErrorMsg = "not found";
                        myaction = View(myLoginModel);
                    }
                }
            }
            catch (Exception ex)
            {
                myLoginModel.ErrorMsg = "not found";
                myaction = View(myLoginModel);
            }
        
            return myaction;
        }

        [HttpGet]
      public ActionResult SignUpView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpView(SignUpModel mymodelSignUp)

        {
            Registration regform = new Registration();
            try
            {
                Byte[] imagedata = { 234 };
                regform.name = mymodelSignUp.Name;
                regform.email = mymodelSignUp.Email;
                regform.address = mymodelSignUp.Address;
                regform.cellNo = mymodelSignUp.CellNo;
                regform.password = mymodelSignUp.Password;
                regform.userType = mymodelSignUp.UserType;
                regform.time = Convert.ToString(DateTime.Now.Date);
                //regform.date = Convert.ToString(DateTime.Now.Date);
                //regform.photo = imagedata;
                if (mymodelSignUp.UserType == "Vendor")
                {
                    regform.isActive = false;
                }
                else
                {
                    regform.isActive = true;
                }
                db.Registrations.Add(regform);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw;
            }
          

            return View();
        }
    }
}
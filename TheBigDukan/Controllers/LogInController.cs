using System;
using System.Collections.Generic;
using System.IO;
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
            if (id != null && pass != null)
            {
                try
                {
                    Registration regform = db.Registrations.Single(w => w.email == id && w.password == pass);
                  //  Response.Write(regform.name);
                    if (ModelState.IsValid)
                    {
                        if (regform == null)
                        {
                            
                            myLoginModel.ErrorMsg = "not found";
                            myaction = View(myLoginModel);
                        }
                        else
                        {
                            SignUpModel mod = new SignUpModel(regform);


                             myaction = RedirectToAction("VenderActionIndex", "Vendor",mod);
                         

                        }
                    }
                }
                catch (Exception ex)
                {
                    myLoginModel.ErrorMsg = "not found";
                    myaction = View(myLoginModel);
                }
            }
            else
            {
                myaction = View();

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

                regform.name = mymodelSignUp.Name;
                regform.email = mymodelSignUp.Email;
                regform.address = mymodelSignUp.Address;
                regform.cellNo = mymodelSignUp.CellNo;
                regform.password = mymodelSignUp.Password;
                regform.userType = mymodelSignUp.UserType;
                regform.time = Convert.ToString(DateTime.Now.Date);
                if (mymodelSignUp.UserType == "Vendor")
                {
                    regform.isActive = false;
                }
                else
                {
                    regform.isActive = true;
                }

                string FileName = Path.GetFileNameWithoutExtension(mymodelSignUp.Image_new.FileName);
                string Extension = Path.GetExtension(mymodelSignUp.Image_new.FileName);
                FileName = FileName + DateTime.Now.ToString("yymmssff") + Extension;
                regform.Image = "~/Pictures/" + FileName;

                FileName = Path.Combine(Server.MapPath("~/Pictures/"), FileName);
                mymodelSignUp.Image_new.SaveAs(FileName);


                db.Registrations.Add(regform);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
               
            }
          

            return View();
        }
    }
}
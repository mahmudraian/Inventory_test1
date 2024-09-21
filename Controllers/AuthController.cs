using Inventory_exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_exam.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(Account model)
        {
            string name = model.Name;
            string password = model.Password;

            if(name !="" && password != "")
            {
                if (name == "Raian" && password == "123456")
                {
                    ViewBag.Message = "Login Success";
                    RedirectToAction("Dashnoard", "Home");

                }
                else
                {
                    ViewBag.Message = "Failed";
                }

            }
          

            return View(model);

        }


    }
}
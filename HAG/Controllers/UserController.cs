using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HAG.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserInfo()
        {
            return View();
        }
        public ActionResult addToSession(List<string> user)
        {
            
            Session["fname"] = user[0];
            Session["lname"] = user[1];
            Session["address"] = user[2];
            Session["phone"] = user[3];

            Console.WriteLine(Session["fname"]);

            return RedirectToAction("Home", "Home");
            
           
        }
           
        }
    }

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HAG.Models;

namespace HAG.Controllers
{
    public class ClientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clients
        
        public ActionResult UserInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddtoSession()
        {
            string firstName = Request["fname"].ToString();
            string lastName = Request["lname"].ToString();
            string address = Request["address"].ToString();
            string phone = Request["phone"].ToString();

            Session["fname"] = firstName;
            Session["lname"] = lastName;
            Session["address"] = address;
            Session["phone"] = phone;

            return RedirectToAction("Home", "Home");
        }

    }
}

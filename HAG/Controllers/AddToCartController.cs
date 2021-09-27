using HAG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HAG.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class AddToCartController : Controller
    {
        public ActionResult OrderSuccessful()
        {
            return View();
        }
        public ActionResult Add(Product pr)
        {
            if (Session["cart"] == null)
            {
                List<Product> li = new List<Product>();
                li.Add(pr);
                Session["cart"] = li;
                ViewBag.cart = li.Count();

                Session["count"] = 1;
            }
            else
            {
                List<Product> li = (List<Product>)Session["cart"];
                li.Add(pr);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }

            return RedirectToAction("Index", "Products");
        }

        public ActionResult Remove(Product pr)
        {
            List<Product> li = (List<Product>)Session["cart"];
            var index = -1;
            var length = li.Count;
            for (int i = 0; i < length; i++)
            {
                if (li[i].id == pr.id)
                {
                    index = i;
                }
            }
            if (index >= 0 || index <= length)
            {
                li.RemoveAt(index);
            }

            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("/");
            //return View();
        }
        public ActionResult Index()
        {
            return View("ShoppingCart");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Data;
using CoffeeShop.Domain.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private CoffeeShopContext db = new CoffeeShopContext();

        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Jojo's Joe. Owned and operated by Joseph Joestar.";

            return View();
        }
    }
}
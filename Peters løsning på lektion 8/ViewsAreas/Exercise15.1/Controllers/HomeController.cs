﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise15_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Sale()
        {
            return View();
        }
        public ActionResult MoreSales()
        {
            return View();
        }
        public ActionResult Buy()
        {
            return View();
        }
        public ActionResult BuyAndSell()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
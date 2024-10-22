using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50);
            glass.ImageUrl = "grandcru.jpg";
            ViewBag.Glass = glass;

            //bin
            Product bin = new Product("Trash bin", 50);
            bin.ImageUrl = "bin_35l.jpg";
            ViewBag.Bin = bin;

            //knife
            Product knife = new Product("Knife", 100);
            knife.ImageUrl = "st_knife.jpg";
            ViewBag.Knife = knife;
			
            return View();
        }

    }
}

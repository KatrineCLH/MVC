using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Opg61.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String name = "Hilda";
            int age = 80;
            DateTime birthday = new DateTime(1944,01,01);

            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.birthday = birthday.Day + "/" + birthday.Month + "-" + birthday.Year;

            return View(new Models.HomeModel(name, age, birthday));
            //return View("SomeIndex", new Models.HomeModel(name, age, birthday));
        }
    }
}
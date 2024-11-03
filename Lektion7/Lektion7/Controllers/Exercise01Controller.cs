using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lektion7.Controllers
{
    public class Exercise01Controller : Controller
    {
        public ActionResult Index(string Country)
        {
            List<SelectListItem> countries = new List<SelectListItem>();
            countries.Add(new SelectListItem { Text = "China", Value = "CN" });
            countries.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countries.Add(new SelectListItem { Text = "United States of America", Value = "US"});

            ViewBag.Countries = countries;
            ViewBag.Title = "Countries";
            ViewBag.CountryCode = Country;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
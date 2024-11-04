using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Lektion7.Controllers
{
    public class Exercise01Controller : Controller
    {
        public ActionResult Index(string Countries)
        {
            List<SelectListItem> countries = new List<SelectListItem>();
            countries.Add(new SelectListItem { Text = "China", Value = "CN" });
            countries.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countries.Add(new SelectListItem { Text = "United States of America", Value = "US"});

            ViewBag.Countries = countries;
            ViewBag.Title = "Countries";
            ViewBag.CountryCode = Countries;

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formData)
        {
           
            
            return View();
        }
    }
}
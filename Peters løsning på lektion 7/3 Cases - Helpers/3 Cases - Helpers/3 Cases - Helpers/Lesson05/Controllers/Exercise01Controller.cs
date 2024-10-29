using Lesson04.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson04.Controllers
{
    public class Exercise01Controller : Controller
    {
        //
        // GET: /Exercise01/

        private List<SelectListItem> countryList = new List<SelectListItem>();
        private int MyId = 0;

        public ActionResult Index(string List)
        {
            // if the session variable isn't set you create the list and store it in a session
            if (Session["countryList"] == null) {
                countryList.Add(new SelectListItem { Text = "Denmark", Value = "DK", Selected = true });
                countryList.Add(new SelectListItem { Text = "France", Value = "FR" });
                countryList.Add(new SelectListItem { Text = "USA", Value = "US" });
                countryList.Add(new SelectListItem { Text = "China", Value = "CN" });
                Session["countryList"] = countryList;
            }
            else {
                // if the sessionvariale is set you'll make a reference to it
                // note that session variable is not strongly typed
                // that's because all types of variables can be stored in sessions
                // therefore you must typecast it to the right type when you assign it to a variable
                countryList = (List<SelectListItem>)Session["countryList"];
            }

            ViewBag.List = countryList;
            ViewBag.CountryCode = List;
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formData) {

            countryList = (List<SelectListItem>)Session["countryList"];

            countryList.Add(new SelectListItem { Text = formData["country"], Value = formData["code"], Selected=true});
            Utilities.SortSelectList(countryList, formData["code"]);

            ViewBag.Country = formData["country"];
            ViewBag.Code = formData["code"];

            ViewBag.List = countryList;
            

            return View();
        }

    }
}

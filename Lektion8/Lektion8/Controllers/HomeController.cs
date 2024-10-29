using Lektion8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lektion8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Opgave 1

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

        //Opgave 2
        public ActionResult VisAlle()
        {
            return View(AllePersoner());
        }

        public ActionResult VisEn()
        {
            return View(AllePersoner()[0]);
        }

        private List<Person> AllePersoner()
        {
            Person ulf = new Person("Ulf", "Pilgaard");
            Person ghitta = new Person("Ghitta", "Nørbye");
            Person dirch = new Person("Dirch", "Passer");
            Person lisbeth = new Person("Lisbeth", "Dahl");

            List<Person> personer = new List<Person>();
            personer.Add(ulf);
            personer.Add(ghitta);
            personer.Add(dirch);
            personer.Add(lisbeth);

            return personer;
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
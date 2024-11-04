using Exercise15_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise15_2.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> AllePersoner()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Luke", "Skywalker"));
            persons.Add(new Person("Obiwan", "Kenobi"));
            persons.Add(new Person("Han", "Solo"));
            return persons;
        }
        public ActionResult VisAlle()
        {
            return View(AllePersoner());
        }
        public ActionResult VisEn()
        {
            return View(new EnOgAlleViewModel(AllePersoner()[0], AllePersoner()));
        }
        
        // udkommerter ChildAction og se du kan kalde direkte fra URL
        //
        // [ChildActionOnly]
        public ActionResult VisEnPerson(Person p)
        {
            if (p.Efternavn == "Skywalker")
            {
                p.Efternavn = "Vader";
            }
            if (p.Efternavn == "Solo")
            {
                p.Efternavn = "Skywalker";
            }
            return PartialView(p);
        }
    }
}
using Lesson02_Startup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise02Controller : Controller
    {
        //
        // GET: /Exercise02/

        public ActionResult Index()
        {
            List<Person> people = new List<Person>();
            Person ole = new Person("Ole", "Olsen", "Vejnavn", "8000", "Aarhus C");
            ole.addPhone("12345678");
            ole.addPhone("12345678");
            ole.addPhone("12345678");
            ole.BirthDate = new DateTime(2003, 08, 16);
            Person hans = new Person("Hans", "Hansen", "Gadegyde", "8200", "Aarhus N");
            hans.addPhone("87654321");
            hans.BirthDate = new DateTime(2001,01,28);
            people.Add(ole);
            people.Add(hans);

            return View(people);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Opg61.Controllers
{
    public class RockbandsController : Controller
    {
        // GET: Rockbands
        public ActionResult Index()
        {
            string[] rockbands = new string[] { "Led Zeppelin", "The Beatles", "Pink Floyd", "The Jimi Hendrix Experience", "Van Halen", "Queen", "The Eagles", "Metallica", "U2", "Bob Marley and the Wailers" };
            ViewBag.rockbands = rockbands;
            
            return View();
        }
    }
}
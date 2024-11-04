using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using Lektion9.Models;

namespace Lektion9.Controllers
{
    public class APIController : ApiController
    {

        [HttpGet]
        public List<Person> getPersoner()
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person(1, "Hans", 20));
            personer.Add(new Person(2, "Ole", 30));
            personer.Add(new Person(3, "Gert", 40));

            return personer;
        }

        [HttpGet]
        public Person getPersonById(int id)
        {
            Person foundPerson = null;
            
            List<Person> personer = new List<Person>();
            personer.Add(new Person(1, "Hans", 20));
            personer.Add(new Person(2, "Ole", 30));
            personer.Add(new Person(3, "Gert", 40));

            bool found = false;
            int i = 0;

            while (!found)
            {
                if (personer[i].Id == id) 
                { 
                    found = true;
                    foundPerson = personer[i];
                }
                else { i++; }
            }

            return foundPerson;
        }

        [HttpPost]
        public void addPerson(Person p)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person(1, "Hans", 20));
            personer.Add(new Person(2, "Ole", 30));
            personer.Add(new Person(3, "Gert", 40));
            personer.Add(p);

            //Console.WriteLine("Der blev tilføjet en person med navn: " + p.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise15_2.Models
{
    public class Person
    {
        public Person() { }
        public Person(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public String Fornavn { get; set; }
        public String Efternavn { get; set; }
    }
}
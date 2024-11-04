using Exercise15_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise15_2.Models
{
    public class EnOgAlleViewModel
    {
        public Person ValgtPerson { get; set; }
        public List<Person> AllePersoner { get; set; }

        public EnOgAlleViewModel(Person valgtPerson, List<Person> allePersoner)
        {
            ValgtPerson = valgtPerson;
            AllePersoner = allePersoner;
        }
    }
}
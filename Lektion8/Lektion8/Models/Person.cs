using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion8.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string FirstName, string LastName) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opg61.Models
{
    public class HomeModel
    {
        public HomeModel(String name, int age, DateTime birthday) 
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }
        public String Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}
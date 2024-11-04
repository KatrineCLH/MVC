using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion9.Models
{
    public class Person
    {
        private int id;
        private string name;
        private int age;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }  
        
        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
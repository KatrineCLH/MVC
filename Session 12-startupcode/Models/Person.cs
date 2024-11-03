using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Lesson02_Startup.Models
{
    public class Person
    {
        //firstname, lastname, address, zip, city, and phone number
        private string firstName;
        private string lastName;
        private string address;
        private string zip;
        private string city;
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;

        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Address { get;set;}
        public string Zip { get;set;}
        public string City {get;set;}
        public List<string> PhoneNumbers 
        { 
            get 
            { 
                return phoneNumbers;
            }
            set 
            { 
                phoneNumbers = value;
            }
        }
        public DateTime BirthDate 
        {
            get { return birthDate; }
            set
            {
                if (value.CompareTo(DateTime.Now) < 0)
                {
                    birthDate = value;
                }
                else
                {
                    throw new Exception("Illegal birthdate");
                }
            }
                }
        public int Age 
        { 
            get 
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthDate.Year;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            } 
        }

        public Person(string firstnavn, string lastnavn, string address, string zip, string city)
        {
            FirstName = firstnavn;
            LastName = lastnavn;
            Address = address;
            Zip = zip;
            City = city;
        }

        public void addPhone(string no)
        {
            phoneNumbers.Add(no);
        }
    }
}
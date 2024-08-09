using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "sensitive data";
        }
    }

    public class Person
    {
        protected string formerLastName = ""; // Allows you access to variables in child classes that inherit.
        public string FirstName { get; private set; } // Private set = the variable can only be changed inside this class, but can be read everywhere.
        public string LastName { get; private set; }
        private string _ssn;

        public string SSN
        {
            get 
            { 
                return $"***-**-{ _ssn.Substring(_ssn.Length-4)}"; 
            }
            set 
            { 
                _ssn = value; 
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            string test = "Hi";
            Console.WriteLine($"Hellow {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
        }


    }
}

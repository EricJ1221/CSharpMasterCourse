using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesDemo
{
    public class PersonModel
    {   // Camelcasing - Good practice because C# is case sensitive - internal variables
        //public string firstName; // not the exact proper way to use data in class instances
        //public string lastName;
        //public string emailAddress; // since these are not static you cannot access them by "PersonModel.firstName etc"

        // Introduction to properties
        // The simple and most commonly used property - auto property
        // Pascal case is the industry standard for properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}

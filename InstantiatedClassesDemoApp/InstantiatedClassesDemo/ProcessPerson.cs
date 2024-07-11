using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesDemo
{
    public static class ProcessPerson
    {
        public static void GreetPerson(PersonModel person) 
        {
            Console.WriteLine($"hello { person.FirstName} {person.LastName}");
            person.HasBeenGreeted = true;
        }
    }
}

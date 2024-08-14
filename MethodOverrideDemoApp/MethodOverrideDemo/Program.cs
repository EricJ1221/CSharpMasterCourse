using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Tip: if you are overriding every method, just implement an interface.


namespace MethodOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = "Jim",
                LastName = "Jones",
                Email = "JimJones@yahoo.com"
            };

            Console.WriteLine(person.FirstName + " " + person.LastName + ", Email: " + person.Email );
            Console.ReadLine();
        }
    }
}

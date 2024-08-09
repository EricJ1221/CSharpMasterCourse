using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You have to be careful with modifiers if you want to keep access to user information secure.
namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            DataAccess data = new DataAccess();

            person.SavePerson();

            Console.ReadLine();
        }
    }
}

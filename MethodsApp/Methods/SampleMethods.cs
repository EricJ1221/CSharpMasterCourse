using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Naming methods is very critical, name them for what they do

//namespace Methods;
//    internal static class SampleMethods // internal method, no need to instantiate ahead of time
//    {

//    }

namespace methods
{
    public static class SampleMethods
    {
        // scope of class

        // Method Parameters - Modify the say hi method to say a persons name
        //public static (string firstName, string lastName) SayHi(string fullName) // void = returns nothing, can name the method whatever you want, must use PascalCasing
        //{
        //    Console.WriteLine($"Hello {firstName}");
        //    // scope of the method defined by {}
        //}

        public static string GetUsersName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            return name;
        }

        // Tuple - allows you to return two or more values
        public static (string firstName, string lastName) GetFullName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            return (firstName,lastName);
        }
        public static void SayGoodbye() 
        {
            Console.WriteLine("Goodbye my user.\nThank you for visiting.\nI cannot wait to see you again.\n");
        }
    }
}
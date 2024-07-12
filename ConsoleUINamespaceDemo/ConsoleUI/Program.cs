using ConsoleUI.Models;
using FoundationInfo;
using FoundationInfo.Calculators.PersonalCalculators.EricsCalculators; // A little ridiculous, but it works.
using System;
using System.Collections.Generic;

// < > - indicates a Generic
// use namespaces to organize your application logically


namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // System.Collections.Generic.List<PersonModel> people = new System.Collections.Generic.List<PersonModel>(); // Without utilising the using statement.
            List<PersonModel> people = new List<PersonModel>();

            // System.Console.WriteLine();  // Without utilising the using statement.
            Console.WriteLine();

            PersonModel person = new PersonModel();

            // FoundationInfo.Calculations.Add(4, 3); // Similar to import statements, but not the same. Allows us to use another namespace aside from the current namespace.
            Calculations.Add(4, 3);

            Console.ReadLine();
        }

    }
}
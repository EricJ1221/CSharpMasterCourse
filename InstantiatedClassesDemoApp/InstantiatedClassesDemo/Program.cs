
// previously covered static classes, the idea that if you put data in them, it lasts for the lifetime of the application and everyone has access to that same data
// instantiated classes are different and address this problem.

// In general, instantiated classes store data. Static classes are for stateless processing. Static classes are not commonly used in the real world.

using InstantiatedClassesDemo;
using System;

namespace ConsoleUI
{
    class Program
    {
        // You have to instantiate the class first, otherwise you cannot use it
        static void main(string[] args)
        {
            // Building a "house" from the "blueprint" (class)
            // PersonModel person = new PersonModel();
            // Console.WriteLine(person.firstName);

            //List <PersonModel> people = new List<PersonModel> (); // This is far more efficient and Scalable
            
            //// The variable holds the street address for the "house" you built
            //PersonModel person = new PersonModel ();

            //person.firstName = "Tim";

            //people.Add (person);

            //person = new PersonModel();

            //person.firstName = "Sue";
            
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.firstName);
            //}
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            do
            {
                Console.WriteLine("What is your first name (or type exit to stop):");
                firstName = Console.ReadLine();

                Console.WriteLine("What is your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit");
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);

                    
                }
            }while (firstName.ToLower() != "exit";
            
            foreach (PersonModel p in people) 
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName }");
            }

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);   
            }
            Console.ReadLine();
        }
    }
}
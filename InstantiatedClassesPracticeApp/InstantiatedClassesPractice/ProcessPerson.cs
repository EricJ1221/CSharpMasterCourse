using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesPractice
{
    internal class ProcessPerson
    {
        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Welcome to my application {person.FirstName} {person.LastName}.");
            person.HasBeenWelcomed = true;

        }

        public static Address GetAddress(string firstName, string lastName) 
        {
            Console.WriteLine($"{firstName} {lastName}, what is your street?");
            string street = Console.ReadLine();
            
            Console.WriteLine("What is your city?");
            string city = Console.ReadLine();

            Console.WriteLine("What is your state?");
            string state = Console.ReadLine();

            Console.WriteLine("What is your zip code?");
            string zipCode = Console.ReadLine();

            return new Address
            {
                Street = street,
                City = city,
                State = state,
                ZipCode = zipCode
            };
        }
    }
}

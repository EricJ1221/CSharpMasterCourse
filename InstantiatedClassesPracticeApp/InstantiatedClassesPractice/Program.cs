



// Create a Console application that has a person class and an Address class

using InstantiatedClassesPractice;

namespace ConsoleUI
{
    class program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.WriteLine("What is your first name? (type exit to stop)");
                firstName = Console.ReadLine();

                if (firstName.ToLower() == "exit")
                {
                    break;  // Exit the loop if the user types "exit"
                }

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();

                Address address = ProcessPerson.GetAddress(firstName, lastName);

                PersonModel person = new PersonModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PersonAddress = address
                };

                people.Add(person);

            } while (true);  // The loop will break internally based on the input

            foreach (PersonModel p in people) 
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} lives at {p.PersonAddress.Street} {p.PersonAddress.City}, {p.PersonAddress.State}, {p.PersonAddress.ZipCode}.");
                ProcessPerson.GreetPerson(p);
            } 
            
            Console.ReadLine();

        }
    }
}
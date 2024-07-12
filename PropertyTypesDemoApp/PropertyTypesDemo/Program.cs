
// Use auto properties by default. Move to full properties when needed. Use private backing and read only when necessary.


using PropertyTypesDemo;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        { 
        PersonModel person = new PersonModel(); // this PersonModel() at the end is a constructor behind the scenes
            person.FirstName = "fName";
            //person.LastName = "lName"; // create a method to set this
            person.Age = 30;
            person.SSN = "123-45-6789";

            Console.WriteLine($"{person.SSN}");
            Console.WriteLine(person.FullName);
        }
    }
}

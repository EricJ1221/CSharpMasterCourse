
// only put User Interface code in here from now on. The rest goes into our class library.
// Always delete class 1 when making a class library

// using DemoLibrary; // DemoLibrary is a separate project, A solution practically just holds two projects in the same location.
// Normally the two projects can't communicate, this is where references come into play. References = import statements, references bring in code
// You cannot add a reference to Console UI, because it would create a circular dependency.

// Store as much of your code as possible in class libaries.
// The caveat, in general don't put UI code into your class libraries, you may be tempted to put in a console Read/write,
// instead just do the work in the class library.


using DemoLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        static void main(string[] args) 
        {

            PersonModel person = new PersonModel();

            person.FirstName = "FirstNameTest";
            person.LastName = "LastNameTest";

            Console.ReadLine();
        }
    }
}
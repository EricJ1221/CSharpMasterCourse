
// Static means you get one copy for your entire application, if you store data its stored for the life cycle of the application
// always name classes well, if the name doesn't describe what the class is doing, rethink what the class is doing and name it accordingly
// always group methods together, math with math, messages with messages, etc.

// public/private are access modifiers

// Don't store data in static classes
// Use class files to separate your code so that each class and each method has its own purpose
//      This helps you follow DRY - Don't Repeat Yourself, lots of files are better than having redundant code

// Calculate Datanotes
// this number would be stored for the entire life of the application, this is why we don't typically store data in a static class
// takes up memory and storage, will cause memory footprint to grow larger over time, it can also step on toes (overwriting other variables)

// RequestData notes
// You can add static to the class and it will apply to all methods, cannot instantiate though


using StaticClasssesDemo;

namespace ConsuleUi
{
    class program
    {
        static void Main(string[] args)
        {
            UserMessages.SayHello();

            CalculateData.MyAge = 40; 
            string firstName = RequestData.GetAString("What is your first name?");

            UserMessages.ApplicationsStartMessage(firstName); // this works because its referenced by the class name first'
            
            double x = RequestData.GetADouble("Please enter your first number.");
            double y = RequestData.GetADouble("Please enter your second number.");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}.");    

        }

    
    }
}
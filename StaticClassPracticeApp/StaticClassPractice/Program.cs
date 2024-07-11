



// Create a console application with a static class that handles calculations

using StaticClassPractice;
using System.Net.Http.Headers;

namespace consoleUI
{
    class program
    {
        static void Main(string[] args)
        {
            
            string firstName = RequestData.GetString("What is your first name?");
            UserMessages.Sayhello(firstName);

            double x = RequestData.GetDouble("Please enter your first double.");
            double y = RequestData.GetDouble("Please enter your secound double.");
            Console.WriteLine();

            double addResult = CalculateData.Add(x, y);
            UserMessages.PrintResultMessage($"The addition of {x} and {y} = {addResult}.");
            double subtractResult = CalculateData.Subtract(x, y);
            UserMessages.PrintResultMessage($"The subtraction of {x} and {y} = {subtractResult}.");
            double divideResult = CalculateData.Divide(x, y);
            UserMessages.PrintResultMessage($"The division of {x} and {y} = {divideResult}.");
            double multiplyResult = CalculateData.Multiply(x, y);
            UserMessages.PrintResultMessage($"The prodcut of {x} and {y} = {multiplyResult}.");

            int pX = RequestData.GetInt("Please enter your first integer.");
            int pY = RequestData.GetInt("Please enter your second integer.");

            int powerResult = CalculateData.Power(pX, pY);
            UserMessages.PrintResultMessage($"{pX} to the power of {pY} = {powerResult}.");

            UserMessages.ThankUser();

        }
    }
}

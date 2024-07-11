using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasssesDemo
{
    public static class RequestData // can add static to the class and it will apply to all methods, cannot instantiate though
    {
        public static string GetAString(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
        public static double GetADouble(string message)
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.WriteLine(message);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            }
            return output;
        }

    }
}

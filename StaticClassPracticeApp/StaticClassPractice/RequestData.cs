using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassPractice
{
    public static class RequestData
    {
        public static string GetString(string message) 
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }

        public static double GetDouble(string message) 
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false) 
            {
                Console.WriteLine("Please enter a valid double.");
                Console.WriteLine(message);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            }
            return output;
        }

        public static int GetInt(string message) 
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            int output;

            bool isInt = int.TryParse(numberText, out output);

            while (isInt == false)
            {
                Console.WriteLine("Please enter a valid integer.");
                Console.WriteLine(message);
                numberText = Console.ReadLine();
                isInt =int.TryParse(numberText, out output);
            }
            return output;
        }
    }
}

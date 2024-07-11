using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StaticClassPractice
{
     public static class UserMessages
    {
        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public static void ThankUser()
        {
            Console.WriteLine("Thank you for using my app to calculate for you.");
        }

        public static void Sayhello(string firstName)
        {
            Console.WriteLine($"Hello {firstName}.");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    internal class ConsoleMethods
    {
        public static string AskUsersName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            return userName;
            
        }

        public static void GreetUser(string userName)
        {
            Console.WriteLine($"Hello {userName}.");
        }

    }
}

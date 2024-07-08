using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void Count()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 72)
                {
                    Console.WriteLine("Approaching 73...");
                }

                if (i == 73)
                {
                    throw new Exception("An exception occurred at 73.");
                }

                Console.WriteLine(i);
            }
        }
    }
}

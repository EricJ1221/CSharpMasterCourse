

// Create a Console Application with a for loop that throws an exception after five iterations
// Catch the exception

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("!!!!EXCEPTION!!!!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("!!!!EXCEPTION!!!!");
            }
        }
    }
}
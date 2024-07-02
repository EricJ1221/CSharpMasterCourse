
//Breakpoints

//Step into - goes step by step

//Step over - Will step over method and calls etc

//Step out - if you are in a method and want to go back to the parent method.




namespace consoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"The value of i is {i}");

                for (int j = 0; j < 10; i++) // Infinite loop because j is never incremented
                {
                    Console.WriteLine($"The value of j is {j}");

                }
            }

            Console.ReadLine();
        }
    }
}


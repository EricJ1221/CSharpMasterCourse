// looking at different ways of using breakpoints, conditions, actions, etc
// being able to export and save breakpoints is pretty awesome for team/personal debugging



namespace ConsoleUI
{
    class program
    {
        public static void Main(string[] args)
        {
            RunsALot();
            Console.ReadLine();
        }
        private static void RunsALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i < 1000; i++) // could use hit count - is a multiple of 100, allows us to skip over a group and find the range that the error is in
            {                                  // change multiple to 2, add conditional expression "is true" when "i>-10"
                total += i;
                try
                {
                    test = 5 / i; // add , actions condition -  "The value of i is {i} continue execution,
                                  // These breakpoints help us not push through test code from the debugging process into production 
                }
                catch
                {
                    Console.WriteLine("There was an exception.");
                }
            }
            Console.WriteLine($"The total is {total}");

        }
    }
}
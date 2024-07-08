




namespace ConsoleUI
{
    class program
    {

        public static void Main(string[] args)
        {
            string name= "";
            try
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();  
                CreateCatchableException(name);
            }
            catch (Exception ex) when (name.ToLower() == "eric") // This gets skipped over because the method works correctly when passed a string name
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("your name is eric");
            }
            finally
            {
                Console.WriteLine("End program.");
            }

        }

        public static void CreateCatchableException(string name)
        {
            Console.WriteLine("You caught the exception.");
        }
    }
}
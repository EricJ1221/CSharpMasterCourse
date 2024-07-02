




namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try // exceptions bubble up, so we try to catch it again
            {
                BadCall();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("We had an error."); // this allows the exception to bubble up to the user interface code
                Console.WriteLine(ex.Message); // The trycatch in the BadCall method could be removed since we are using the trycatch around the call
            }

            Console.ReadLine();
        }

        private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++) // should be "<" not "<=", poor coding for exception catching
            {

                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex) // Created a variable to stor the exception
                {
                    Console.WriteLine("We had an error.");
                    Console.WriteLine(ex.Message); // More appropriate for a user.
                    //Console.WriteLine(ex); // Use if writing to a log file, more information to help find the exception in the logs
                    // throw; // This allows us to catch the exception up the line, but treats it like it never got caught.
                    // throw ex; // causes a problem in the stack trace and shows line 42
                    throw new Exception("There was an error handling our array", ex);
                }

            }
        }
    }
}






using System.Collections.Concurrent;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                DifferentMethod(); // When you run this the first exception is caught and the other methods are not ran, if an exception is caught, the block is closed

                //Console.WriteLine("What is your name?");
                //name = Console.ReadLine();
                //ComplexMethod(name);
                //SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling these methods.");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException) // added no variable here to not create something that I am not going to use
            {
                Console.WriteLine("You forgot to finish your code");
            }
            catch (Exception ex) when (name.ToLower() == "tim") // can add when to "dial in" what the exception is
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {

                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("I always run."); // can be used to close out any connections in case the code crashes.
            }
            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for this method.");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim.");
            }
        }
        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod"); // Method overloading, 3 different options of parameters to send to the method
        } // This allows us to create our own exceptions, through the creation of new exception instances

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly.");
            //throw new NotImplementedException();
        }

        
    }
}
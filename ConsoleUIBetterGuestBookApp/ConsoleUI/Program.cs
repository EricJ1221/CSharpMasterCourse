
// Capture the information about each guest (assumption, at least one guest, unknown maximum)
// Info to Capture: First name, Last name, Message to the host
// Once done, loop through each guest and print their info

// Design your app with just UI content in the UI. Put everything else ina class library.

using GuestBookLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>(); // variables can live outside of the method and is now in scope after our refactoring
           // probably not the best practice if memory is a concern                                                         
        static void Main(string[] args) 
        { 
           
            GetGuestInformation();

            PrintGuestInformation();


            Console.ReadLine();

        }
        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();

                //Console.WriteLine("What is your first name?"); // In reality you would want to validate all data being entered for storage
                guest.FirstName = GetInfoFromConsole("What is your first name?");

                guest.LastName = GetInfoFromConsole("What is your last name?");

                guest.MessageToHost = GetInfoFromConsole("What is your message to the host?");

                moreGuestsComing = GetInfoFromConsole("Are more guests coming? (yes/no)");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
                
        }
    }
}
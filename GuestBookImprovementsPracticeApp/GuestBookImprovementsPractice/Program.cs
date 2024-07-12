
using GuestbookLibrary;
using GuestbookLibrary.Models;

// recreate the guest book project without looking back
// take the concept and Create the application

// Capture the information about each guest (assumption, at least one guest, unknown maximum)
// Info to Capture: First name, Last name, Message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>(); // instantiate this in the class so that it can be used by class methods
        static void Main(string[] args) 
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();

        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();
                guest.FirstName = GetInfoFromConsole("What is your first name?");


                guest.LastName = GetInfoFromConsole("What is your last name?");

                guest.MessageToHost = GetInfoFromConsole("What is your message to the host?");

                moreGuestsComing = GetInfoFromConsole("Are there more guests coming? (yes/no)");
                
                guests.Add(guest);

            } while (moreGuestsComing.ToLower() == "yes");

        }

        private static string GetInfoFromConsole(string message) // helper method to grab guest info from the Console
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
    }
}
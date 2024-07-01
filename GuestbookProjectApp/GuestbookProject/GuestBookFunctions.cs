using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GuestbookProject
{
    public static class GuestBookMethods
    {
        public static (string, int) GreetTheUser(Dictionary<string, int> guestBook)
        {
            Console.WriteLine("Thank you for attending our event this evening.");
            Console.WriteLine("Lets get you checked in on the guest list.");
            Console.WriteLine("What is your full name?");
            string name = Console.ReadLine();

            while (!IsValidNameFormat(name))
            {
                Console.WriteLine("Please enter a valid full name in the format 'Firstname Lastname':");
                name = Console.ReadLine();
            }

            
            string[] fullName = name.Split(' '); // splitting first name from full name
            string lastNameOnly = fullName[1];

            Console.WriteLine($"Hello Mr. or Mrs. {lastNameOnly}, how many guests in total are with you this evening?");
            int size = int.Parse(Console.ReadLine());

            DuplicateReservationName(name, size, guestBook);

            Console.WriteLine($"Welcome, {lastNameOnly} family, party of {size}.");
            Console.WriteLine("Press enter to add the next guest, or Exit to close the application and tally the total number of guests in attendance .\n");

            return (name, size);
        }


        private static bool IsValidNameFormat(string name)
        {
            // Regex pattern to match alphabetic characters and optionally spaces
            string pattern = @"^[A-Za-z]+(?:\s[A-Za-z]+)?$";
            return Regex.IsMatch(name, pattern);
        }

        public static int TotalNumGuests(Dictionary<string, int> guestBook)
        {
            int totalGuests = 0;
            List<string> guests = new List<string>();

            foreach (var pair in guestBook)
            {

                guests.Add(pair.Key + ", ");
                totalGuests += pair.Value;
            }
            Console.WriteLine("The entire guest list is as follows:");
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }

            return totalGuests;
        }

        public static void DuplicateReservationName(string fullName, int partySize, Dictionary<string, int> guestBook)
        {
            if (guestBook.ContainsKey(fullName.ToLower()))
            {
                Console.WriteLine($"{fullName} is already in the guest book. Please provide us with an alias:");

                string alias = Console.ReadLine().Trim(); // Read alias from user input

                // Check if alias already exists
                while (guestBook.ContainsKey(alias))
                {
                    Console.WriteLine($"Alias '{alias}' is already taken. Please provide a different alias:");
                    alias = Console.ReadLine().Trim();
                }

                // Add the alias with the same partySize
                guestBook.Add(alias, partySize);
                Console.WriteLine($"Thank you for your help, Mr. or Mrs. {alias}. Party of {partySize}, enjoy your evening.");
            }
            else
            {
                // If fullName doesn't exist, add it to the guestBook
                guestBook.Add(fullName, partySize);
            }
        }
    }
}

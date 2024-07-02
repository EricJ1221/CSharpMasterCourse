


namespace GuestbookProjectRevision
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            // - Welcome the user 
            // -- intro the app name 

            Console.WriteLine("Welcome to the Guest Book App.");
            Console.WriteLine("******************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            // - ask user for their name
            // -- store the name

            Console.WriteLine("What is your party/group name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            // - ask user for number in their party
            // -- store the number
            // -- convert string to a number (int)
            bool isValidNumber;
            int output;
            do
            {
                Console.WriteLine("How many people are in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output); 
                if (!isValidNumber)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (isValidNumber = false);

            return output;
        }
        
        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new List<string>();   

            do
            {
                guests.Add(GetPartyName());

                totalGuests += GetPartySize();

            } while (AskToContinue());

            return (guests, totalGuests);
        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Are there more guests coming (yes/no): ");
            string continueLooping = Console.ReadLine();
            Console.WriteLine(); 

            bool output = (continueLooping.ToLower() == "yes");
            return output;
        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine($"The {guest} Family.");
            }
        }

        public static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine("Thank you for everyone who attended.");
            Console.WriteLine($"The total guest count for this evening was {totalGuests}.");
            Console.WriteLine();
        }
    }
}

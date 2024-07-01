


// Guest Book Project
// Build a console Guest Book
// Ask the user for their name and how many are in their party
// keep track of how many are at the party
// at the end print out the guest list and the total number of guests

// First thoughts, I need a dictionary. Use the user name as the key and have it point to the number of people in their party, including the user
// Then iterate over the dictionary for each key and add up the total number of participants

using GuestbookProject;

Dictionary<string, int> guestBook = new Dictionary<string, int>();

while (true)
{
    (string fullName, int partySize) = GuestBookMethods.GreetTheUser(guestBook);

    
    if (Console.ReadLine().ToLower() == ("exit"))
    {
        int totalGuests = GuestBookMethods.TotalNumGuests(guestBook);
        Console.WriteLine($"The total number of guests in attendance tonight was {totalGuests}.\n");
        break;
    }    
}

    
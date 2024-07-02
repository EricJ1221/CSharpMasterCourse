// This is a revision of the GuestBookProject I created previously.
// Some of the requirements were implied and can be implemented more efficiently.


using GuestbookProjectRevision;



GuestLogic.WelcomeMessage();

var (guests, totalGuests) = GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);

GuestLogic.DisplayGuestCount(totalGuests);  




// - add the number to total

// - Check to see if more guests are coming
// -- loop back to the top until no more guests

// - Loop over the names list and print them

// - Print the total guest count
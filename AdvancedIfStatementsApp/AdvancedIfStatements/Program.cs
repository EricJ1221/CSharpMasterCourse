


Console.WriteLine("What is your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("What is your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine();

if (firstName.ToLower() == "jim" && 
    lastName.ToLower() == "jones")
{
    Console.WriteLine("Hello Mr. Jones.");
}
else if (firstName.ToLower() == "jim"
{
    Console.WriteLine("You have a cool first name.");
}
else if (lastName.ToLower() == "jones")
{
    Console.WriteLine("You have a great last name.");
}
else
{
    Console.WriteLine("Sorry for you don't have a cooler name.");
}

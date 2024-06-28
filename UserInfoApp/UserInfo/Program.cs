


// get the users name, age, if they are alive and their phone number

using System.Collections.Concurrent;

Console.WriteLine("Hello, what is your name?");
string fullName;
string firstName;
string lastName;   

fullName =Console.ReadLine();

string[] nameParts = fullName.Split(' ');

if (nameParts.Length >= 2)
{
    firstName = nameParts[0];
    lastName = nameParts[1];

    Console.WriteLine("First name: " + firstName);
    Console.WriteLine("Last name: " + lastName);
}

else
{
    Console.WriteLine("Please enter your first and last names separated by a space");
    return;
}
Console.WriteLine();


// assessing user age
int userAge;

Console.WriteLine(firstName + " what is your age?");
while (!int.TryParse(Console.ReadLine(), out userAge) || userAge < 0)
{
    Console.WriteLine("Please enter a valid age.");
}

Console.WriteLine(firstName + " " + lastName + " is " + userAge + " years old.");
Console.WriteLine();

// Is user alive
bool aliveOrNot;
Console.WriteLine(firstName + " are you alive?");

if(Console.ReadLine() == "yes" ||  Console.ReadLine() == "Yes")
{
    aliveOrNot = true;
    Console.WriteLine(aliveOrNot);
}

else
{
    aliveOrNot = false;
    Console.WriteLine(aliveOrNot);
}
Console.WriteLine();

// ask for their phone number

string userPhoneNumber;

Console.WriteLine(firstName + " what is your phone number? No spaces please. Example 1110002222");

userPhoneNumber = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("The user's name is " + firstName + " " + lastName);
Console.WriteLine("The user is " + userAge + " years old.");
Console.WriteLine("The users existence is " + aliveOrNot + ".");
Console.WriteLine("The users phone number is " + userPhoneNumber + ".");
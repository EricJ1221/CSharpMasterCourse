


// create an array of 3 names
// Ask the user which number to select
// return the name of the number given
// make sure to check for invalid numbers

string data = "John Redcorn, Hank Hill, Peggy Hill";

string[] fullNames = new string[3];

for (int i = 0; i < fullNames.Length; i++)
{
    fullNames[i] = data.Split(", ")[i];
    Console.WriteLine($"Name at position {i}: {fullNames[i]}");
}
Console.WriteLine();

int userCount = 0;

while (userCount != 1)
{
    Console.WriteLine("Pick a number between 0 and 2:");
    if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 0 && userChoice <= 2)
    {
        // Display the corresponding name based on user's choice
        Console.WriteLine($"The name corresponding to number {userChoice} is: {fullNames[userChoice]}");
        userCount++; // Exit the loop after successful selection
    }
    else
    {
        Console.WriteLine("Invalid input. Please choose a valid number between 0 and 2.\n");
    }
}






//firstNames[count] = data.Split(' ')[count];
//lastNames[count] = data.Split(", ")[count];

//Console.WriteLine($"First name: {firstNames[count]}.");
//Console.WriteLine($"Last name: {lastNames[count]}.");
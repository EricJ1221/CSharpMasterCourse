

// Ask the user for a comma-separted list of first names
// Split the string into an array
// Loop through the array and print "Hello <name> for each person

Console.WriteLine("Hello would you please provide me with a comma separated list of first names.");
string data = Console.ReadLine();

string[] firstNames = data.Split(',');

for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}.");
}

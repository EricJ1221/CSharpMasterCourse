

// Ask the user for their first name.
// Continue  asking for first names until there are no more.
// Then loop through each name using foreach and tell each person hello.

List<string> firstNames = new List<string>();

while (true)
{
    Console.WriteLine("Enter your first name (or type 'quit' to finish):");
    string input = Console.ReadLine();

    if (input.ToLower() == "quit")
    {
        break; // Exit the loop if user enters "quit"
    }

    firstNames.Add(input); // Add the entered name to the list
}

// Greet each person using foreach loop
foreach (string name in firstNames)
{
    Console.WriteLine($"Hello, {name}!");
}
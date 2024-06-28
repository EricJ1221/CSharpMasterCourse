


using System.Collections.Concurrent;

bool isComplete = true;

if (isComplete)
{
    Console.WriteLine("The statement was true.");
    Console.WriteLine("This line should run if true");
}
else
{
    Console.WriteLine("The statement was false.");
    Console.WriteLine("This line should run if false");
}

Console.WriteLine("End of program.");
Console.WriteLine();



Console.WriteLine("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "jim")
{
    Console.WriteLine("Hello Mr. Jones");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program");
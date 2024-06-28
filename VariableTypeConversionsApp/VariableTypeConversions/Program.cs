


// String to something else

using System.Collections.Concurrent;

Console.WriteLine("What is your age: ");
string? ageText = Console.ReadLine();

//int age = int.Parse(ageText);

bool isValidInt = int.TryParse(ageText, out int age); // declared age in line

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

int ageIn15 = age + 15;

Console.WriteLine(ageIn15);
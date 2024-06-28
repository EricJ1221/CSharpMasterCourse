


// Capture the user's age from the console

Console.WriteLine("What is your age: ");

string? ageText = Console.ReadLine();

bool isValidint = int.TryParse(ageText, out var age);
Console.WriteLine($"This is a valid age: {age}");

Console.WriteLine($"You will be {age + 25}, in 25 years.");
Console.WriteLine($"You were {age - 25}, 25 years ago.");

// Identify how old they will be in 25 years, as well as how old they were 25 years before


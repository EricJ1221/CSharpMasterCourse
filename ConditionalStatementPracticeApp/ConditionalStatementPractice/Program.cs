


// ask the user for their name and age
// if their name is bob or sue, address them as professor
// if the person is under 21, recommend they wait X years to start this class

Console.WriteLine("Hello, what is your name?");
string firstName = Console.ReadLine();

Console.WriteLine($"{userName}, what is your age?");
string ageText = Console.ReadLine();

string formattedName;

// A more robust approach to the question
if (int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("You did not provide a valid age.");
    return;
}
if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}
if (age < 21)
{
    Console.WriteLine($"I reccomend you wait {21 - age} years, {formattedName}");
}
else
{
    Console.WriteLine($"Welcome to class {formattedName}.");
}

// A less robust approach to the question

//if (int.TryParse(ageText, out int age))
//{
//    if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
//    {
//        formattedName = $"Professor {firstName}";
//    }
//    else
//    {
//        formattedName = firstName;
//    }
//    if (age < 21)
//    {
//        Console.WriteLine($"I reccomend you wait {21 - age} years, {formattedName}");
//    }
//    else
//    {
//        Console.WriteLine($"Welcome to class {formattedName}.");
//    }
//}
//else
//{
//    Console.WriteLine("You did not provide a valid age.");
//}


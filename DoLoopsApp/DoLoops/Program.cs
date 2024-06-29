
// Ask the user for their name
// welcome Jim as professor and anyone else as a student
// Do this until the user types exit

string userName;

do
{
    Console.WriteLine("What is your name: ");
	userName = Console.ReadLine();
	if (userName.ToLower() == "jim")
	{
        Console.WriteLine($"Hello Professor {userName}.");
		Console.WriteLine();
    }
	else if (userName.ToLower() != "exit")
	{
        Console.WriteLine("Hello student.");
        Console.WriteLine();
    }

} while (userName.ToLower() != "exit");








// practically the same but have important differences
// both will run continually until the condition is false


//// do while loop
//do
//{
			// Runs the code at least once
//} while (true);

//// while loop


//while (true) ;
//{
			// Runs the code 0 or more times
//}


//bool isValidAge;
//int age;
//int testNumber = 0;

//do
//{
//    Console.WriteLine(testNumber);
//    testNumber -= 3;
//    // testNumber++; 
//} while (testNumber <= 100); // while ("true"), lots of infinite loop possibillities if done poorly


// Runs all the code in the curlybraces until isValidAge is true
// This code doesn't account for words such as "four", etc.
//do
//{
//	Console.WriteLine("What is your age: ");
//	string ageText = Console.ReadLine();

//	isValidAge = int.TryParse(ageText, out age);

//	if (isValidAge == false)
//	{
//		Console.WriteLine("That was an invalid age.");
//	}
//}
//while (isValidAge == false) ;

//Console.WriteLine($"Your age is {age}");
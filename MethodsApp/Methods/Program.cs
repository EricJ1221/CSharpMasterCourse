
// Best practices to follow when building applications.
//
// DRY - Don't Repeat Yourself
// 
// DRY is centered around not repeating logic, this saves you time and space in your applications.
// Also reduces the potential for bugs in your code.

// SOLID - the "S" in SOLID, stands for SRP - Single Responsibility Principle
// SRP - Basically says that something should do one thing. So make your methods to do one thing and do them well.
// 




using methods;
using Methods;
using System.Collections.Concurrent;

//string name = SampleMethods.GetUsersName();

//SampleMethods.SayHi(name);

double result = MathShortcuts.Add(5,3);
Console.WriteLine($" The result is {result}.\n");
Console.WriteLine($" The result is {MathShortcuts.Add(5, 3)}.\n");

double[] vals = new double[] { 2, 5, 6, 21, 78, 99 };

MathShortcuts.AddAll(vals);

(string firstName, string lastName) fullName = SampleMethods.GetFullName();

//SampleMethods.SayHi(fullName);

SampleMethods.SayGoodbye();

//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}






List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Adam");
firstNames.Add("Sue");

Console.WriteLine(firstNames[firstNames.Count - 1]);    

List<int> ages = new List<int>();
ages.Add(1);    
ages.Add(2);
ages.Add(3);
ages.Add(4);

// List<T> - generic

string data = "Corey,Smith,Jones";

List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");

for (int i = 0; i < lastNames.Count; i++)
{
    Console.WriteLine(lastNames[i]);
}
Console.WriteLine();

lastNames.Add(lastNames[0] = "Johnson"); // replaces Sue with Johnson

for (int i = 0; i < lastNames.Count; i++)
{
    Console.WriteLine(lastNames[i]);
}
Console.WriteLine();


// Add students to a class roster List until there are no more students.
// Then print out the count of the students to the console.


string students = "Jim,John,Sue,Tom,Mark";
List<string> roster = new List<string>();

// Split the students string and add them to the roster list
roster.AddRange(students.Split(','));

// Print out the count of students in the roster list
Console.WriteLine($"Number of students: {roster.Count}");
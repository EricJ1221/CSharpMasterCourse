
Dictionary<int, string> lookup = new Dictionary<int, string>();

Dictionary<string, string> animalHuman = new Dictionary<string, string>();

//lookup.Add(1, "Tom");
//lookup.Add(2, "Jerry");
//lookup.Add(3, "cat");
//lookup.Add(4, "mouse");

animalHuman["animal"] = "Not a human";
animalHuman["fish"] = "Not a human that swims";
animalHuman["human"] = "Us";

Console.WriteLine($"The definiont of fish is {animalHuman["fish"]}");


//Console.WriteLine($"The employee with ID number 28 is {employees[28]}.");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");


// Create a dictionary list of employee IDs and the name that goes with the ID
// Ask the user for their id and return their name, make sure to check for invalid answers


//Dictionary<int, string> employees = new Dictionary<int, string>();
//employees[95] = "Jim Jones";
//employees[50] = "Sue Storm";
//employees[28] = "Tom Cat";
//employees[29] = "Rick Ross";
//employees[30] = "Jody Highroller";

Dictionary<int, string> employees = new Dictionary<int, string>
        {
            { 95, "Jim Jones" },
            { 50, "Sue Storm" },
            { 28, "Tom Cat" },
            { 29, "Rick Ross" },
            { 30, "Jody Highroller" }
        };

int userID;
int count = 0;

Console.WriteLine("What is your employee ID?");
while(count != 1)
{
    int.TryParse(Console.ReadLine(), out userID);

    // Check if the userID exists in the dictionary
    if(employees.ContainsKey(userID))
    {
        string userName = employees[userID];
        Console.WriteLine($"Welcome, {userName}!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid ID. Please enter a valid employee ID.");
    }
}

 
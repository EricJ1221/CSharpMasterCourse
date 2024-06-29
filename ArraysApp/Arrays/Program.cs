


string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "John";
firstNames[2] = "Sue";
firstNames[3] = "Jan";
firstNames[4] = "Tom";

int count = 0;

while (firstNames.Length <= 5)
{
    Console.WriteLine($"Hi, my name is {firstNames[count]}.");
    count++;
    if (count == 5)
    {
        break;
    }
}

string data = "Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday";

string[] daysOfWeek = new string[7];
int dayCount = 0;

while (daysOfWeek.Length <= 7)
{
    if (dayCount != 7)
    {
        daysOfWeek[dayCount] = data.Split(',')[dayCount];
        Console.WriteLine(daysOfWeek[dayCount]);
        dayCount++;
    }
}




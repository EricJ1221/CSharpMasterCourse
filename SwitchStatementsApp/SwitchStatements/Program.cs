


string firstName = "Sue";
int age = 43;

switch (age)
{
    case >= 0 and > 18:
        Console.WriteLine("You are a child or young adult.");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job.");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are about to retire.");
        break;
    default:
        Console.WriteLine("Age was not in an expected range.");
        break;
}



//switch (firstName.ToLower())
//{
//    //case "sue": // example of "fall through"
//    case "jim" or "sue": // or instead of ||
//        Console.WriteLine("Hello Jim");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you");
//        break;
//}
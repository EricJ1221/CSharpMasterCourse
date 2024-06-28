

using System.Globalization;

DateTime today = DateTime.Now;

//DateTime birthday = DatTime.Parse("6/11/1998");

//DateTime birthday = DateTime.ParseExact("6/11/1998", "d,M,yyyy", CultureInfo.InvariantCulture); // more common format for outside the US

//Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString( "MMMM dd, yyyy hh:mm tt zzz"));
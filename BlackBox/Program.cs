using System.Globalization;

string time = "September 14 2025";
string format = "MMM dd yyyy";
if (DateTime.TryParse(time,  out var parseDate))
{
    Console.WriteLine(parseDate.ToString("yyyy-MM-dd"));
}
else
{
    Console.WriteLine("invalid format");
}

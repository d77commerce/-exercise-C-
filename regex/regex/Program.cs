using System;
using System.Text.RegularExpressions;

namespace onezuker
{
    class Program
    {
        static void Main(string[] args)
        {


            var inPut = Console.ReadLine();
            MatchCollection matchData = Regex.Matches(inPut, @"\b(?<day>[0-9]{2})(?<sparator>.)(?<month>[A-Z][a-z]{2})\k<sparator>(?<year>[0-9]{4})\b");

            foreach (Match data in matchData)
            {
                Console.WriteLine($"Day: {data.Groups["day"]}, Month: {data.Groups["month"]}, Year: {data.Groups["year"]}");
            }
            
        }
    }
}

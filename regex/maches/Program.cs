using System;
using System.Text.RegularExpressions;

namespace maches
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = @"Jhon Smith jhfjfhkfiufuifyiufy Pavel Penchev Maria Bakalova";
            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");
            Match matchName = nameRegex.Match(input);
            MatchCollection allNames = nameRegex.Matches(input);

            foreach (Match allName in allNames)
            {
                Console.WriteLine(allName.Value);
            }
        }
    }
}

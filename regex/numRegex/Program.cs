using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace numRegex
{
    class Program
    {
        static void Main(string[] args)
        {
           // string pattern = @"\b(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, @"\+359.2.\d{3}.\d{4}");

            //Console.WriteLine(phoneMatches.Count);

            string[] matchPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}

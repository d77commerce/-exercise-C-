using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //>>([A-z]+)<<([0-9]+.*[0-9]*)!([0-9])
            string input = Console.ReadLine();
            decimal result = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                
                Match separator = Regex.Match(input, @"^>>([A-z]+)<<([0-9]+\.{0,1}[0-9]{0,})!([0-9]+)");
                if (!separator.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string item = separator.Groups[1].Value;
                decimal price = decimal.Parse(separator.Groups[2].Value);
                int qtu = int.Parse(separator.Groups[3].Value);
                result += price * qtu;
                Console.WriteLine(item);

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {result:f2}");
        }
    }
}

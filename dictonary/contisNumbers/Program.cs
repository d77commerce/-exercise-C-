using System;
using System.Collections.Generic;
using System.Linq;

namespace contisNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();
            SortedDictionary<double, int>contii = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
           
            {
                if (!contii.ContainsKey(numbers[i]))
                {
                    contii[numbers[i]] = 0;
                }

                contii[numbers[i]]++;
               
            }

            foreach (var number in contii)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}

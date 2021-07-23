using System;
using System.Collections.Generic;

namespace dyctonaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> humanWeights = new Dictionary<string, int>();
            humanWeights.Add("izo", 72);
            humanWeights.Add("pecho", 48);
            foreach (var item in humanWeights)
            {
                Console.WriteLine($"Name: {item.Key} \n Weght: {item.Value}");
            }

        }
    }
}

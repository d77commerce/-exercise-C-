using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string inPut = Console.ReadLine();
            while (inPut != "stop")
            {
                string inPutKey = inPut;
                if (result.ContainsKey(inPutKey) != true)
                {
                    result.Add(inPutKey, 0);
                }

                inPut = Console.ReadLine();
                int digitNum = int.Parse(inPut);
                result[inPutKey] += digitNum;

                inPut = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

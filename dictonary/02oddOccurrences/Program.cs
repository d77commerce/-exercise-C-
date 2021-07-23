using System;
using System.Collections.Generic;

namespace _02oddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            Dictionary<string, int> outPut = new Dictionary<string, int>();
            foreach (var item in input)
            {
                string wordLoCase = item.ToLower();
                if (outPut.ContainsKey(wordLoCase))
                {
                    outPut[wordLoCase]++;
                }
                else
                {
                    outPut.Add(wordLoCase, 1);
                }



            }
            foreach (var item2 in outPut)
            {
                if (item2.Value % 2 != 0)
                {
                    Console.Write(item2.Key+" ");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = Console.ReadLine()
                .Split();
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var word in inPut)
            {
                char[] newChar = word.ToCharArray();

                foreach (var i in newChar)
              
                {
                    if (result.ContainsKey(i) != true)
                    {
                        result.Add(i,1);
                    }
                    else
                    {
                        result[i]++;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

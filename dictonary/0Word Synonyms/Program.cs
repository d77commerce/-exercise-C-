﻿using System;
using System.Collections.Generic;

namespace _03Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
                if (words.ContainsKey(word)==false)
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(sinonim);

            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}

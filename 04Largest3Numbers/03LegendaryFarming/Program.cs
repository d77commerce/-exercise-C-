using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var artItems = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0},

            };
            var junk = new Dictionary<string, int>();
            bool finish = true;

            while (finish)
            {
                string[] inPut = Console.ReadLine().Split();

                for (int i = 0; i < inPut.Length; i+=2)
                {
                    int point = int.Parse(inPut[i]);
                    string inputItems = inPut[i + 1].ToLower();
                    if (inputItems== "shards")
                    {
                        artItems["shards"] += point;
                    }
                    else if (inputItems== "fragments")
                    {
                        artItems["fragments"] += point;
                    }
                    else if (inputItems == "motes")
                    {
                        artItems["motes"] += point;
                    }
                    else
                    {
                        if (!junk.ContainsKey(inputItems))
                        {
                            junk[inputItems] = 0;
                        }
                        junk[inputItems] += point;
                    }
                    if (artItems.Values.Any(x => x >= 250))
                    {
                        finish = false;
                        break;
                    }
                }

            }
            if (artItems["shards"] >= 250)
            {
                artItems["sharads"] -= 250;
                Console.WriteLine($"Shadowmourne obtained!");
               
            }
            else if (artItems["fragments"] >= 250)
            {
                artItems["fragments"] -= 250;
                Console.WriteLine($"Valanyr obtained!");
               
            }
            else if (artItems["motes"] >= 250)
            {
                artItems["motes"] -= 250;
                Console.WriteLine($"Dragonwrath obtained!");
               
               
            }

            foreach (var item1 in artItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item1.Key}: {item1.Value}");
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace listsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> sum = new List<int>();
            for (int i = 0; i < num.Count / 2; i++)
            {
                int test = num[i] + num[num.Count - 1 - i];

                sum.Add(test);

            }
            if (num.Count % 2 == 1)
            {
                sum.Add(num[num.Count / 2]);
            }

            Console.WriteLine(string.Join(" ",sum));

        }


    }
}

using System;

namespace zigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] oneL = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] inNombers = Console.ReadLine().Split(" ");
                int first = int.Parse(inNombers[0]);
                int last = int.Parse(inNombers[1]);
                if (i % 2 == 0)
                {
                    oneL[i] = first;
                    second[i] = last;
                }
                else
                {
                    oneL[i] = last;
                    second[i] = first;
                }

            }
            Console.WriteLine(string.Join(" ",oneL));
           
            Console.WriteLine(string.Join(" ",second));
        }

    }
}

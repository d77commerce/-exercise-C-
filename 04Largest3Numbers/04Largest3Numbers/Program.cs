using System;
using System.Linq;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arange = num.OrderByDescending(n => n).ToArray();
            int count = 0;
            for (int i = 0; i < arange.Length; i++)
        
            {
                Console.Write(arange[i]+" ");
                count++;
                if (count == 3)
                {
                    break;
                }
            }
        }
    }
}

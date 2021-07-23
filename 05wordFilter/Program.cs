using System;
using System.Linq;

namespace _05wordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = Console.ReadLine()
                 .Split()
                 .Where(w => w.Length % 2 == 0)
                 .ToArray();
            foreach (var item in inPut)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}

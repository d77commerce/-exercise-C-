using System;
using System.Text;

namespace repearString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = Console.ReadLine().Split();

            StringBuilder newStr = new StringBuilder();

            foreach (var word in inPut)
            {
                int count = word.Length;
                for (int i = 0; i <count; i++)
                {
                    newStr.Append(word);
                }
            }
            Console.WriteLine(newStr);
        }
    }
}

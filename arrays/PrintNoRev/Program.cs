using System;

namespace PrintNoRev
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

        }

        private static void NewMethod()
        {
            int n = int.Parse(Console.ReadLine());
            int[] revNo = new int[n];
            for (int i = 0; i < revNo.Length; i++)
            {
                revNo[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < revNo.Length; i++)
            {
                Console.WriteLine(revNo[i]);
            }
        }
    }
}

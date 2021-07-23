using System;

namespace wwwwwwaaaqqqwsw
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = char.Parse(Console.ReadLine());
            int b = char.Parse(Console.ReadLine());

            NewMethod(a, b);
        }

        private static void NewMethod(int a, int b)
        {
          

            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
           
        }
    }
}

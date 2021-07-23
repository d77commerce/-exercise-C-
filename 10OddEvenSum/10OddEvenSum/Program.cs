using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 0; i < n; i++)               
            {
                int nomber = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    even += nomber;
                }
                else
                {
                    odd += nomber;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even-odd)}");
            }

        }
    }
}

using System;

namespace _09LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            for (int i = 0; i < n; i++)
            {
                left = left +int.Parse( Console.ReadLine());
            }
            int right = 0;
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }
            if(left == right)
            {
            
                Console.WriteLine($"Yes, sum = {left}");

            }
            else
            {
               
                int diff = Math.Abs(right - left);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}

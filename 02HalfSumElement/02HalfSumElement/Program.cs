using System;

namespace _02HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < nom; i++)

            {
                int x = int.Parse(Console.ReadLine());
                sum += x;
                if (x > max)
                {
                    max = x;
                }


               

            }
            int notXsum = sum-max;
            if (max == notXsum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs( max- notXsum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);

            }





        }
    }
}

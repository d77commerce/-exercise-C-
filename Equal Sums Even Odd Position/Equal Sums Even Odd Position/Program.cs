using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            for (int i = first; i <= last; i++)
            {
                int nonber = i;
                int evenTotal = 0;
                int oddTotal = 0;
                int con = 0;

                while (nonber != 0)
                {
                    int secondNomb = nonber % 10;
                    if (con % 2 == 0)
                    {
                        evenTotal += secondNomb;
                    }
                    else
                    {
                        oddTotal += secondNomb;
                    }
                    nonber /= 10;
                    con++;
                }
                if (evenTotal == oddTotal)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}

using System;

namespace _04Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
           double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;



            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());

                if (x < 200)
                {
                    p1++;
                }
               else if (x >= 200 && x < 400)
                {
                    p2++;
                }
              else  if (x >= 400 && x < 600)
                {
                    p3++;
                }
              else  if (x >= 600 && x < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }


            }
            double p1x = p1 / n * 100;
            double p2x = p2 / n * 100;
            double p3x = p3 / n * 100;
            double p4x = p4 / n * 100;
            double p5x = p5 / n * 100;
           

            Console.WriteLine($"{p1x:f2}%");
            Console.WriteLine($"{p2x:f2}%");
            Console.WriteLine($"{p3x:f2}%");
            Console.WriteLine($"{p4x:f2}%");
            Console.WriteLine($"{p5x:f2}%");

        }
    }
}

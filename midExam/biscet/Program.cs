using System;

namespace biscet
{
    class Program
    {
        static void Main(string[] args)
        {
            double workerPerDay = double.Parse(Console.ReadLine());
            double worker = double.Parse(Console.ReadLine());
            double product30day = double.Parse(Console.ReadLine());

            double calculateDay = workerPerDay * worker;
            
            double total = 0;
            double fullDay = 20 * calculateDay;
            double partDay = 10 * (Math.Floor(calculateDay * 0.75));
            total = fullDay + partDay;
           

            if (total > product30day)
            {
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                double diff = Math.Abs(product30day - total);
                double diffPercent = ((diff / product30day) * 100);

                Console.WriteLine($"You produce {diffPercent:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You have produced {total} biscuits for the past month.");
                double diff = Math.Abs(product30day - total);
                double diffPercent = ((diff / product30day) * 100);
                Console.WriteLine($"You produce {diffPercent:f2} percent less biscuits.");
            }
        }
    }
}

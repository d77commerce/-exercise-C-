using System;

namespace _1.nationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int staf1 = int.Parse(Console.ReadLine());
            int staf2 = int.Parse(Console.ReadLine());
            int staf3 = int.Parse(Console.ReadLine());
            int peple= int.Parse(Console.ReadLine());
            double totalH= 0;
            double pouse = 0;
            int ansuerPerH = staf1 + staf2 + staf3;

            while (peple >= ansuerPerH)
            {
                peple -= ansuerPerH;
                totalH ++;
                 pouse ++;
                if (pouse == 3)
                {
                    totalH++;
                    pouse = 0;
                }
            }
            if (peple > 0)
            {
                totalH++;
            }
            Console.WriteLine($"Time needed: {totalH}h.");
        }
    }
}

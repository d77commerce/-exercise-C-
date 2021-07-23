using System;

namespace 2222222
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetProcesors = int.Parse(Console.ReadLine());
            int workars = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalH = workars * 8 * days;
            double totalProsesors = totalH / 3;
            double totalXx = Math.Floor(totalProsesors);
            double tottalProfit = totalXx * 110.10;
            double targetProfit = targetProcesors * 110.10;
            if (totalXx > targetProcesors)
            {
                double yY = tottalProfit - targetProfit;
                Console.WriteLine($"Profit: -> {yY:f2} BGN");
            }
            else
            {
                double yX = targetProfit - tottalProfit;
                Console.WriteLine($"Losses: -> {yX:f2} BGN");
            }
        }
    }
}

using System;

namespace _111111
{
    class Program
    {
        static void Main(string[] args)
        {
            // На първия ред: цена на една видео карта – цяло число в интервала[1 … 2000]
            //• На втория ред: цена на един преходник – цяло число в интервала[1 … 50]
            //• На третия ред: цена на консумирания ток от карта за ден – реално число в интервала[0.01... 10.00]
            //• На четвъртия ред: печалба от една карта за един ден – реално число в интервала[1.00... 100.00]

            int videocard = int.Parse(Console.ReadLine());
            int conector = int.Parse(Console.ReadLine());
            double acdc = double.Parse(Console.ReadLine());
            double profitdaycard = double.Parse(Console.ReadLine());
            int totalspend = (videocard * 13) + (conector * 13) + 1000;
            double totalProfitday = profitdaycard -acdc;
            double totalprofit = totalProfitday * 13;
            double monyback = totalspend / totalprofit;
            Console.WriteLine(totalspend);
            Console.WriteLine(Math.Ceiling(monyback));

        }
    }
}

using System;

namespace charityCampane
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ⦁	Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //⦁	Броят на сладкарите – цяло число в интервала[0 … 1000]
            //⦁	Броят на тортите – цяло число в интервала[0… 2000]
            //⦁	Броят на гофретите – цяло число в интервала[0 … 2000]
            //⦁	Броят на палачинките – цяло число в интервала[0 … 2000]

            int day = int.Parse(Console.ReadLine());
            int chef = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int vafell = int.Parse(Console.ReadLine());
            int panCake = int.Parse(Console.ReadLine());

            double cakePerDay = cake * 45;
            double vafellPerDay = vafell * 5.8;
            double pancekePerDay = panCake * 3.2;


            double sumPerDay = cakePerDay + vafellPerDay + pancekePerDay;



            double sumChefsPercamp = sumPerDay * chef * day;

            double profit = sumChefsPercamp - sumChefsPercamp / 8 ;
            Console.WriteLine(profit );



        }
    }
}

using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double xMoney = double.Parse(Console.ReadLine());
            double totalMoney = xMoney;
            int dayCunter = 0;
            int dayspend = 0;

            while (dayspend != 5)
            {
                string saveOrSpend = Console.ReadLine();
                double Money = double.Parse(Console.ReadLine());

                dayCunter++;
                switch (saveOrSpend)
                {
                    case "save":
                        dayspend = 0;
                        totalMoney += Money;
                        break;
                    case "spend":
                        totalMoney -= Money;
                        dayspend++;
                        if (totalMoney < Money)
                        {
                            totalMoney = 0;
                        }
                        break;

                }
                if (totalMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCunter} days.");
                    return;
                }



            }
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(dayCunter);

        }
    }
}

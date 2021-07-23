using System;

namespace catHood
{
    class Program
    {
        static void Main(string[] args)
        {
            int cat = int.Parse(Console.ReadLine());
            double foodPrice = 12.45;
            double foodPerDay = 0;
            double totalfood = 0;
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            for (int i = 0; i < cat; i++)
            {
                foodPerDay = double.Parse(Console.ReadLine());
                totalfood += foodPerDay;
                if (foodPerDay >= 100 && foodPerDay < 200)
                {
                    g1++;
                }
                else if (foodPerDay >= 200 && foodPerDay < 300)
                {
                    g2++;
                }
                else
                {
                    g3++;
                }


            }
            Console.WriteLine($"Group 1: {g1} cats.");
            Console.WriteLine($"Group 2: {g2} cats.");
            Console.WriteLine($"Group 3: {g3} cats.");
            double x = totalfood / 1000;

            Console.WriteLine($"Price for food per day: {foodPrice * x:f2} lv."
);
        }
    }
}

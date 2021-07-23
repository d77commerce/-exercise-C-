using System;

namespace dicount1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sity = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            double profit = 0;
            switch (sity)
            {
                case "Sofia":
                    if (volume >= 0 && volume <= 500)
                    {
                        profit = volume * 0.05;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        profit = volume * 0.07;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        profit = volume * 0.08;
                    }
                    else if (volume > 10000)
                    {
                        profit = volume * 0.12;
                    }
                    break;
                case "Varna":
                    if (volume >= 0 && volume <= 500)
                    {
                        profit = volume * 0.045;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        profit = volume * 0.075;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        profit = volume * 0.10;
                    }
                    else if (volume > 10000)
                    {
                        profit = volume * 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (volume >= 0 && volume <= 500)
                    {
                        profit = volume * 0.055;
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        profit = volume * 0.08;
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        profit = volume * 0.12;
                    }
                    else if (volume > 10000)
                    {
                        profit = volume * 0.145;
                    }
                    break;


            }

            if ((profit > 0) && (volume > 0) ||(sity=="Sofia")||(sity=="Plovdiv")||(sity=="Varna"))
            {
                Console.WriteLine($"{ profit:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }



        }
    }
}

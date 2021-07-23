using System;

namespace fruShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuite = Console.ReadLine();
            string day = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double totalPrint = 0;

           // if (fuite != "banana" || fuite != "apple" || fuite != "orange" || fuite != "grapefruit" || fuite != "kiwi" || fuite != "pineapple" || fuite != "grapes")
            //{
             //   Console.WriteLine("error");
               // return;
            //}

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fuite)
                {
                    case "banana":
                        totalPrint = x * 2.50;
                        break;
                    case "orange":
                        totalPrint = x * 0.85;
                        break;
                    case "apple":
                        totalPrint = x * 1.20;
                        break;
                    case "grepefruit":
                        totalPrint = x * 1.45;
                        break;
                    case "kiwi":
                        totalPrint = x * 2.70;
                        break;
                    case "pineapple":
                        totalPrint = x * 5.50;
                        break;
                    case "grapes":
                        totalPrint = x * 3.85;
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fuite)
                {
                    case "banana":
                        totalPrint = x * 2.70;

                        break;
                    case "orange":
                        totalPrint = x * 0.90;
                        break;
                    case "apple":
                        totalPrint = x * 1.25;
                        break;
                    case "grapefruit":
                        totalPrint = x * 1.60;
                        break;
                    case "kiwi":
                        totalPrint = x * 3.00;
                        break;
                    case "pineapple":
                        totalPrint = x * 5.60;
                        break;
                    case "grapes":
                        totalPrint = x * 4.20;
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            if (totalPrint == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalPrint:f2}");
            }
        }

    }
}

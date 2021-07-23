using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIn = 0;
            string x = Console.ReadLine();
            double total = 0;
            
            while(x!= "NoMoreMoney")
            {
                moneyIn = double.Parse(x);
                if (moneyIn < 0 )
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: { moneyIn:f2}" );
                 total+=moneyIn;

                x = Console.ReadLine();



            }
            
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}

using System;

namespace gradieit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double total = 0;
            int a = 0;
            
            int clas = 0;
            while (true)
            {
                double x = double.Parse(Console.ReadLine());

                total += x;
                clas++;

                if (x <= 4)
                {

                    a++;
                    if (a == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas-1} grade"
);
                        break;
                    }

                }
                if (clas == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {total /12:f2}"
);
                    break;
                }
            }

        }
    }
}

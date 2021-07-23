using System;

namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double nom = double.Parse(Console.ReadLine());
            string inp = Console.ReadLine();
            string outp = Console.ReadLine();

            double inMm = 0;

            switch (inp)
            {
                case "mm":

                    inMm = nom;
                    
                        if (outp == "mm")
                        {
                            Console.WriteLine($"{inMm:f3}");
                        }
                        else if (outp == "cm")
                        {
                            Console.WriteLine($"{inMm / 10:f3}");

                        }
                        else if (outp == "m")
                        {
                            Console.WriteLine($"{inMm / 1000:f3}");
                        }

                        break;

                case "cm":
                    inMm = nom * 10;

                    if (outp == "mm")
                    {
                        Console.WriteLine($"{inMm:f3}");
                    }

                    else if (outp == "m")
                    {
                        Console.WriteLine($"{inMm / 1000:f3}");
                    }
                    break;
                case "m":
                    inMm = nom * 1000;
                    if (outp == "mm")
                    {
                        Console.WriteLine($"{inMm:f3}");
                    }
                    else if (outp == "cm")
                    {
                        Console.WriteLine($"{inMm / 10:f3}");

                    }

                    break;

            }






        }
    }
}

using System;

namespace figure
{
    class Program
    {

        static void Main(string[] args)
        {
            string figure = (Console.ReadLine());

            if (figure == "square")
            {
                double square = double.Parse(Console.ReadLine());
                Console.WriteLine(square * square);

            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);

            }
            else if (figure == "circle")
            {

                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * a * a);

            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                Console.WriteLine(a * ha / 2);
            }


        }
    }
}

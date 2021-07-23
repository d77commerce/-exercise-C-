using System;

namespace dogFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int dogFoodGrams = dogFood * 1000;
            int dogFoodDay = 0;
            string x= (Console.ReadLine());
            while (x != "Adopted")
            {
                dogFoodDay += int.Parse(x);
                x = Console.ReadLine();
            }
            if (dogFoodGrams < dogFoodDay)
            {
                Console.WriteLine($"Food is not enough. You need {dogFoodDay - dogFoodGrams} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {dogFoodGrams-dogFoodDay} grams.");
            }


        }
    }
}

using System;

namespace frutVeg
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string taype = "";

            if (x == "banana" || x == "apple" || x == "kiwi" || x == "cherry" || x == "lemon" || x == "grapes") 
            {
                taype = "fruit";
            }
            else if (x == "tomato" || x == "cucumber" || x == "pepper" || x == "carrot")
            {
                taype = "vegetable";
            }
            else
            {
                taype = "unknown";
            }
            Console.WriteLine(taype);
        }
    }
}

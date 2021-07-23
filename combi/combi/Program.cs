using System;

namespace combi
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i <= nom; i++)
            {
                for (int y = 0; y <= nom; y++)
                {
                    for (int x = 0; x <= nom; x++)
                    {
                       if(i+y+x==nom)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
       
    }
}

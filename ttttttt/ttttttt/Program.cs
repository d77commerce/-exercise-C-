using System;

namespace ttttttt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                for (int x = 1; x <=n; x++)
                {
                    for (int y = 97; y < 97+l; y++)
                    {
                        for (int q = 97; q <97+l; q++)
                        {
                            for (int z = 0; z <=n; z++)
                            {
                                if(z>i && z > x)
                                {
                                    Console.Write($"{i}{x}{Convert.ToChar(y)}{Convert.ToChar(q)}{z} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace textVertical
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;
            int total = 0;
            for (int ij = 0; ij <= text.Length - 1; ij++)


            {
                switch (text[ij])
                {
                    case 'a':
                        total += 1;

                        break;
                    case 'e':
                        total += 2;
                        break;
                    case 'i':
                        total += 3;
                        break;
                    case 'o':
                        total += 4;
                        break;
                    case 'u':
                        total += 5;
                        break;



                }



 

            }
           Console.WriteLine(total);

        }
    }
}

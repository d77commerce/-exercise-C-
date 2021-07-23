using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            char[] intt = x .ToLower().ToCharArray();

            NewMethod(intt);

        }

        private static void NewMethod(char[] intt)
        {
            int total = 0;
            for (int i = 0; i < intt.Length; i++)
            {
               
                if (intt[i] == 'a')
                {
                    total++;
                }
                if (intt[i] == 'e')
                {
                    total++;
                } 
                if (intt[i] == 'o')
                {
                    total++;
                } 
                if (intt[i] == 'u')
                {
                    total++;
                }
                 if (intt[i] == 'i')
                {
                    total++;
                }
                  if (intt[i] == 'y')
                {
                    total++;
                }
                


            }
            Console.WriteLine(total);
        }
    }
}

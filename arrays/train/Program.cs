using System;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vagon = new int[n];
            int total = 0;
            for (int i = 0; i < vagon.Length; i++)
            {
                int pep = int.Parse(Console.ReadLine());
                vagon[i] = pep;
                total += pep;
            }
            for (int i = 0; i < vagon.Length; i++)
            {
                Console.Write(vagon[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}

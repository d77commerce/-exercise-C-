using System;
using System.Collections.Generic;

namespace _05order
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,double[]>result= new Dictionary<string, double[]>();
            string inPut = Console.ReadLine();
            int totalCount = 0;
            while (inPut != "buy")
            {
                string[] separator = inPut.Split();
                string articul = separator[0];
                double price = double.Parse(separator[1]);
                int count = int.Parse(separator[2]);

                if (!result.ContainsKey(articul))
                {
                    result.Add(articul, new double[2]);
                }
                double lastQty = result[articul][1];
                double[] newQty = new double[] { price, count+lastQty };
                result[articul] = newQty;

                inPut = Console.ReadLine();
            }
            foreach (var item in result)
            {
                double total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}

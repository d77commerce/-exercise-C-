using System;

namespace _11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ⦁	Възрастта на Лили - цяло число в интервала[1...77]
            //⦁	Цената на пералнята – реално число
            //⦁	Цена на играчки – реално число
            int age = int.Parse(Console.ReadLine());
            double washM = double.Parse(Console.ReadLine());
            double toysSale = double.Parse(Console.ReadLine());
            double save = 0;
            double saveAcomol = 10;
            int nomToys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    save += saveAcomol;
                    saveAcomol+=10;
                    save--;
                }
                else
                {
                    nomToys ++;
                }
            }
            double toysSave = nomToys * toysSale;
            save += toysSave;
            if (save >= washM)
            {
                double xR = save - washM;
                Console.WriteLine($"Yes! {xR:f2}");
            }
            else
            {
                double xN = washM - save;
                Console.WriteLine($"No! { xN:f2}");
            }
        }




    }
}

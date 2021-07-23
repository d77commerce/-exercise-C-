using System;

namespace tttt
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string suvenir = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            string choisProd = "";
            double valueProduct = 0;
            switch (team)
            {
                case "Argentina":
                    switch (suvenir)
                    {
                        case "flags":
                            choisProd = "flags";
                            valueProduct = 3.25;
                            break;
                        case "caps":
                            choisProd = "caps";
                            valueProduct = 7.20;
                            break;
                        case "posters":
                            choisProd = "posters";
                            valueProduct = 5.10;
                            break;
                        case "stickers":
                            choisProd = "stickers";
                            valueProduct = 1.25;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;



                    }
                    break;

                case "Brazil":
                    switch (suvenir)
                    {
                        case "flags":
                            choisProd = "flags";
                            valueProduct = 4.20;
                            break;
                        case "caps":
                            choisProd = "caps";
                            valueProduct = 8.50;
                            break;
                        case "posters":
                            choisProd = "posters";
                            valueProduct = 5.35;
                            break;
                        case "stickers":
                            choisProd = "stickers";
                            valueProduct = 1.20;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;

                    }
                    break;
                case "Croatia":
                    switch (suvenir)
                    {
                        case "flags":
                            choisProd = "flags";
                            valueProduct = 2.75;
                            break;
                        case "caps":
                            choisProd = "caps";
                            valueProduct = 6.90;
                            break;
                        case "posters":
                            choisProd = "posters";
                            valueProduct = 4.95;
                            break;
                        case "stickers":
                            choisProd = "stickers";
                            valueProduct = 1.10;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;

                    }
                    break;
                case "Denmark":
                    switch (suvenir)
                    {
                        case "flags":
                            choisProd = "flags";
                            valueProduct = 3.10;
                            break;
                        case "caps":
                            choisProd = "caps";
                            valueProduct = 6.50;
                            break;
                        case "posters":
                            choisProd = "posters";
                            valueProduct =4.80;
                            break;
                        case "stickers":
                            choisProd = "stickers";
                            valueProduct = 0.90;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            return;

                    }
                    break;

                default:
                    Console.WriteLine("Invalid country!");
                    return;



            }
            Console.WriteLine($"Pepi bought {x} {choisProd} of {team} for {valueProduct*x:f2} lv.");

        }
    }
}

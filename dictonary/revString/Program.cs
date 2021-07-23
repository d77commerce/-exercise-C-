using System;

namespace revString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string rewWord = "";
            while (word != "end")
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    rewWord += word[i];
                }
                Console.WriteLine($"{word} = {rewWord}");
                rewWord = "";
                word = "";
                word = Console.ReadLine();

            }


        }
    }
}

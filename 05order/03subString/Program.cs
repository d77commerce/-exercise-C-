using System;


namespace _03subString
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();


            int wordIndex = text.IndexOf(removeWord);

            while (wordIndex != -1)
            {
                text = text.Remove(wordIndex, removeWord.Length);
                wordIndex = text.IndexOf(removeWord);
            }
            Console.WriteLine(text);
        }
    }
}

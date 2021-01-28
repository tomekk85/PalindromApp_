using System;

namespace PalindromApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the word you want to check if it's Palindrom");
            string input_word = Console.ReadLine();
            Palindrom pal = new Palindrom(input_word);
            Console.WriteLine(pal.IsPalindrom() ? "Given word/phrase is a Palindrom" : "Given word/phrase is not a Palindrom");

        }
    }
}

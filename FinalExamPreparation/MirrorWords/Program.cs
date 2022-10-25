using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<wordOne>[A-Za-z]{3,})\1{2}(?<wordTwo>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            MatchCollection words = Regex.Matches(input, pattern);
            if (words.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                //return;
            }
            else
            {
                Console.WriteLine($"{words.Count} word pairs found!");
            }
            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            foreach (Match item in words)
            {
                string wordOne = item.Groups["wordOne"].Value;
                string wordTwo = item.Groups["wordTwo"].Value;
                string wordTwoReversed = "";
                for (int i = wordTwo.Length - 1; i >= 0; i--)
                {
                    wordTwoReversed += wordTwo[i];
                }
                if (wordOne == wordTwoReversed)
                {
                    mirrorWords.Add(wordOne, wordTwo);
                }
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach (var item in mirrorWords)
                {
                    count++;
                    if (count == mirrorWords.Count)
                    {
                        Console.Write($"{item.Key} <=> {item.Value}");
                    }
                    else 
                    { 
                    Console.Write($"{item.Key} <=> {item.Value}, ");
                    }
                } 
            }
        }
    }
}

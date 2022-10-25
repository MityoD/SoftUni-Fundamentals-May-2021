using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string coolTresholdPattern = @"[0-9]";
            string input = Console.ReadLine();
            BigInteger treshold = 1;
            BigInteger currentTreshold = 0;
            MatchCollection coolTreshold = Regex.Matches(input, coolTresholdPattern);
            foreach (Match item in coolTreshold)
            {
                treshold *= BigInteger.Parse(item.Value);
            }
            Console.WriteLine($"Cool threshold: {treshold}");
            string emojiPattern = @"([:*])\1(?<emoji>[A-Z][a-z]{2,})\1{2}";
            MatchCollection emoji = Regex.Matches(input, emojiPattern);
            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in emoji)
            {
                string currentEmoji = item.Groups["emoji"].ToString();
                foreach (var letter in currentEmoji)
                {
                    
                        currentTreshold += letter; 
                }
                if (currentTreshold > treshold)
                {
                    Console.WriteLine(item.Value);
                }
                currentTreshold = 0;
            }
        }
    }
}

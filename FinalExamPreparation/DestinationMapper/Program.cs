using System;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=\/])(?<location>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            int travelPoints = 0;
            MatchCollection match = Regex.Matches(input, pattern);
            Console.Write($"Destinations:");
            int count = 1;
            foreach (Match item in match)
            {
                string location = item.Groups["location"].Value;
                travelPoints += location.Length;
                if (count == match.Count)
                {
                    Console.Write($" {location}");
                }
                else
                {
                Console.Write($" {location},");                        
                }
                count++;
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|]{1})(?<name>[A-Za-z ]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<cal>[0-9]+)\1";
            string input = Console.ReadLine();
            int totalCal = 0;
            MatchCollection match = Regex.Matches(input, pattern);
            foreach (Match item in match)
            {
                totalCal += int.Parse(item.Groups["cal"].ToString());
            }           
            int days = totalCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match item in match)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["cal"].Value}");
            }
        }
    }
}

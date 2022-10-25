using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> runners = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(", ");
            string namePatern = "[A-Za-z]";
            string distancePatern = "[0-9]";
            foreach (var item in input)
            {
                runners.Add(item, 0);
            }
            string command = "";
            while ((command = Console.ReadLine()) != "end of race")
            {
                string currentName = string.Empty;
                int currentDistance = 0;
                MatchCollection letters = Regex.Matches(command, namePatern);
                foreach (Match letter in letters)
                {
                    currentName += letter.Value;
                }
                if (!runners.ContainsKey(currentName))
                {
                    continue;
                }
                MatchCollection digits = Regex.Matches(command, distancePatern);
                foreach (Match digit in digits)
                {
                    currentDistance += int.Parse(digit.Value);
                }
                runners[currentName] += currentDistance;
            }
            int count = 1;
            foreach (var item in runners.OrderByDescending(x => x.Value))
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                count++;
            }
        }
    }
}

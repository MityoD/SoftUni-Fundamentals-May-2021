using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> runners = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(", ");
            string name = "";
            int distance = 0;
            foreach (var item in input)
            {
                runners.Add(item, 0);
            }           
            string command = "";
            while ((command = Console.ReadLine()) != "end of race")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (char.IsDigit(command[i]))
                    {
                        distance += int.Parse(command[i].ToString());
                    }
                    else if (char.IsLetter(command[i]))
                    {
                        name += command[i];
                    }
                }
                if (runners.ContainsKey(name))
                {
                    runners[name] += distance;
                }
                distance = 0;
                name = "";
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

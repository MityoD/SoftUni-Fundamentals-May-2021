using System;
using System.Collections.Generic;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] commandArgs = command.Split("-");
                string username = commandArgs[0];
                if (commandArgs.Contains("banned"))
                {
                    if (results.ContainsKey(username))
                    {
                        results.Remove(username);
                        continue;
                    }
                }
                string language = commandArgs[1];
                int points = int.Parse(commandArgs[2]);
                if (!results.ContainsKey(username))
                {
                    results.Add(username, 0);
                }
                if (points > results[username])
                {
                    results[username] = points;
                }
                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 0);
                }
                submissions[language] += 1;

            }           
            Console.WriteLine("Results:");
            foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}

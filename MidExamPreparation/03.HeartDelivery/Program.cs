
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            int location = 0;
            List<int> hadVD = new List<int>();
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] commandArgs = command.Split();
                int jumpLenght = int.Parse(commandArgs[1]);
                if (jumpLenght + location < neighborhood.Count)
                {
                    location += jumpLenght;
                }
                else
                {
                    location = 0;
                }
                if (hadVD.Contains(location))
                {
                    Console.WriteLine($"Place {location} already had Valentine's day.");
                    continue;
                }
                if (neighborhood[location]>0)
                {
                neighborhood[location] -= 2;
                }
                if (neighborhood[location] == 0)
                {
                    Console.WriteLine($"Place {location} has Valentine's day.");
                    hadVD.Add(location);
                }


            }       
            Console.WriteLine($"Cupid's last position was {location}.");
            neighborhood.RemoveAll(x =>  x == 0);
            if (neighborhood.Count == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count} places.");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _0503.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> pirateShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command = "";
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);
                    if (index < 0 || index > warship.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        warship[index] -= damage;
                    }
                    foreach (var section in warship)
                    {
                        if (section <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);
                    if (startIndex < 0 || startIndex > pirateShip.Count - 1 || endIndex < 0 || endIndex > pirateShip.Count - 1 || startIndex > endIndex)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);
                    if (index < 0 || index > pirateShip.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (pirateShip[index] + health > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int count = 0;
                    double minHealth = (double)maxHealth * 0.2;
                    foreach (var section in pirateShip)
                    {
                        if (section < minHealth)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
 
            }
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warship.Sum()}");


        }
    }
}

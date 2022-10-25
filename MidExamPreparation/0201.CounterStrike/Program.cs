
using System;

namespace _0201.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            double energy = double.Parse(Console.ReadLine());
            string command = "";
            int battleCounter = 0;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy >= distance)
                {
                    battleCounter++;
                    energy -= distance;
                    if (battleCounter % 3 == 0)
                    {
                        energy += battleCounter;
                    }
                    continue;
                }
                else if (energy < distance)
                {

                    Console.WriteLine($"Not enough energy! Game ends with {battleCounter} won battles and {energy} energy");
                    return;
                }
            }
            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {battleCounter}. Energy left: {energy}");
            }
        }
    }
}

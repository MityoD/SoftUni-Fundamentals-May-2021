using System;
using System.Collections.Generic;
using System.Linq;

namespace bombnumredo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            string[] commandArgs = command.Split();
            int bombNum = int.Parse(commandArgs[0]);
            int bombPower = int.Parse(commandArgs[1]);
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bombNum)
                {
                    for (int j = i - bombPower; j <= i + bombPower; j++)
                    {
                        if (j < 0 || j >= sequence.Count)
                        {
                            continue; ;
                        }
                        sequence[j] = 0;
                    }
                    
                }
            }
            
            Console.WriteLine(sequence.Sum());
        }
    }
}

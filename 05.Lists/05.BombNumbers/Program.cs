using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a sequence of numbers and a special bomb number with a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power - his neighbors from left and right. Detonations are performed from left to right and all detonated numbers disappear. Finally print the sum of the remaining elements in the sequence.
            */
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            string[] commandArgs = command.Split();
            int bombNum = int.Parse(commandArgs[0]);
            int bombPower = int.Parse(commandArgs[1]);
            int sum = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == bombNum)
                {
                    for (int j = 0; j <= bombPower; j++)
                    {
                        sequence.RemoveAt(i);
                        if (sequence.Count - 1 < i)
                        {
                            break;
                        }
                    }
                        int tempBP = bombPower;
                    for (int k = 0; k < bombPower; k++)
                    {
                        sequence.RemoveAt(i - tempBP);
                        tempBP--;
                        if (i - tempBP > sequence.Count)
                        {
                            sequence.RemoveAt(i - tempBP=);

                            break;
                        }
                        //if (sequence.Count - 1 < i)
                        //{
                        //    break;
                        //}
                    }
                }
            }
            for (int i = 0; i < sequence.Count; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine(sum);
        }
    }
}

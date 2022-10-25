using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int mostLeftIndex = int.MaxValue;
            int currentSum = 0;
            int bestSum = 0;
            int currentSequence = 1;
            int bestSequence = 1;
            int currentCount = 0;
            int bestCount = 0;
            int[] bestDNA = new int[lenght];
            while (command != "Clone them!")
            {
                currentCount++;
                int[] dna = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sum = 0;
                int index = 0;
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 1)
                    {
                        sum += 1;
                    }
                }
                currentSum = sum;
                sum = 0;
                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == 1 && (dna[i] == dna[i + 1]))
                    {
                        currentSequence++;
                        if (currentSequence > bestSequence)
                        {
                            index = i;
                            bestSequence = currentSequence;
                            mostLeftIndex = index;
                            bestDNA = dna;
                            bestCount = currentCount;
                            bestSum = currentSum;
                        }
                        if (currentSequence == bestSequence && index < mostLeftIndex)
                        {
                            bestDNA = dna;
                            mostLeftIndex = index;
                            bestCount = currentCount;
                            bestSum = currentSum;
                        }
                        if (currentSequence == bestSequence && index == mostLeftIndex && bestSum < currentSum)
                        {
                            bestDNA = dna;
                            mostLeftIndex = index;
                            bestCount = currentCount; 
                            bestSum = currentSum;
                        }
                        currentSequence = 1;
                        currentSum = 0;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCount} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
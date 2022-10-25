using System;
using System.Collections.Generic;
using System.Linq;

namespace _0303.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double average = double.Parse($"{(double)input.Sum() / input.Count :F2}");
            int count = 0;
            int maxNum = int.MinValue;
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    newNumbers.Add(input[i]);
                }
            }
            if (newNumbers.Count > 0) {
                newNumbers.Sort();
            newNumbers.Reverse();
            if (newNumbers.Count > 5)
            {
                for (int i = newNumbers.Count - 1; i >= 5; i--)
                {
                    newNumbers.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(" ", newNumbers));
            }
            else
            {
                Console.WriteLine("No");
            }            
        }
    }
}

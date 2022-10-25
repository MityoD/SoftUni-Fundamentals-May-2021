using System;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int firstValue = 0;
            for (int i = 0; i < rotations; i++)
            {
                firstValue = input[0];
                for (int j = 0; j < input.Length -1; j++)
                {
                input[j] = input[j + 1];
                }
                input[input.Length - 1] = firstValue;
            }
            Console.Write(string.Join(" ", input));
        }
    }
}

using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if ((input[i] + input[j]) == sum)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                        break;
                    }
                }//1 7 6 2 19 23
            }


        }
    }
}

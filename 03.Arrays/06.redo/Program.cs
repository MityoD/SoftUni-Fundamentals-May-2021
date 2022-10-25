using System;
using System.Linq;

namespace _06.redo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int k = i + 1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum += input[i];
                    rightSum = 0;
                }
            }
            if (input.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

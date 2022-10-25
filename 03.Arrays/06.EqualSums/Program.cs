using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool found = false;
            for (int i = 0; i < input.Length; i++)
            {
                leftSum += input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i + 1);
                    found = true;
                }
                else
                {
                    rightSum = 0;
                }
            }
            if (!found && input.Length > 1)
            {
                Console.WriteLine("no");
            }
            if (input.Length == 1)
            {
                Console.WriteLine(0);
            }

        }
    }
}

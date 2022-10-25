using System;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstNumber = input[0];
            int secondNumber = input[1];
                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }
            Console.Write(string.Join(" ",firstArray));
            Console.WriteLine();
            Console.Write(string.Join(" ",secondArray));
        }
    }
}

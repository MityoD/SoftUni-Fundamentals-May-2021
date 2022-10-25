using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = 0;
            int newElement = 0;
            int mostLeft = 0;
            int index = 0;
            int count = 1;
            int newCount = 1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                    index = i;
                    element = input[i];
                }
                else
                {
                    count = 1;
                }
                if (count > newCount)
                {
                    newCount = count;
                    mostLeft = index;
                    newElement = element;

                }
            }
            for (int j = 0; j < newCount; j++)
            {
            Console.Write(newElement + " ");

            }
        }
    }
}

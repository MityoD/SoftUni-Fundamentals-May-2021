using System;
using System.Linq;

namespace _05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        isBigger = true;
                    }
                    else
                    {
                        isBigger = false;                        
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(input[i] + " ");
                }
            }
            if (isBigger == false)
            {
            Console.Write(input[input.Length - 1]);
            }

        }
    }
}

using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a method that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1[0] with str2[0] and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.*/
            string[] arguments = Console.ReadLine().Split();
            int sum = 0;
            string longStr = "";
            string shortStr = "";
            if (arguments[0].Length > arguments[1].Length)
            {
                longStr = arguments[0];
                shortStr = arguments[1];
            }
            else //if (arguments[0].Length < arguments[1].Length)
            {
                longStr = arguments[1];
                shortStr = arguments[0];
            }
            for (int i = 0; i < shortStr.Length; i++)
            {
                int args1 = arguments[0][i];
                int args2 = arguments[1][i];
                sum += args1 * args2;
            }
            for (int i = shortStr.Length; i < longStr.Length; i++)
            {
                sum += longStr[i];
            }
            Console.WriteLine(sum);
        }
    }
}

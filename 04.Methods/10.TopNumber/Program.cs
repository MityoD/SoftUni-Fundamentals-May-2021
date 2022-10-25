using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A top number is an integer that holds the following properties:
     •	Its sum of digits is divisible by 8, e.g. 8, 16, 88.
     •	Holds at least one odd digit, e.g. 232, 707, 87578.
 Write a program to print all master numbers in the range [1…n].
 */
            int n = int.Parse(Console.ReadLine());
            MasterNumbers(n);
        }

        private static void MasterNumbers(int n)
        {
            int sum = 0;
            for (int i = 17; i <= n; i++)
            {
                bool containsOddDigit = false;

                int index = i;
                while (index>0)
                {
                sum += index % 10;
                index /= 10;
                }
                 index = i;

                while (index > 0)
                {
                    int currentNum = index % 10;
                    if (currentNum % 2 !=0)
                    {
                        containsOddDigit = true;
                        break;
                    }
                    index /= 10;
                }

                if (sum % 8 == 0 && containsOddDigit)
                {
                    Console.WriteLine(i);
                }
                    sum = 0;
            }
        }
    }
}

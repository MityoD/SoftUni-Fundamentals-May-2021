using System;

namespace _1SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SmallestNumber(a, b, c); 
        }

        private static void SmallestNumber(int a, int b, int c)
        {
            int result = b;
            if (a<b)
            {
                result = a;
            }
            if (result > c)
            {
                result = c;
            }
            Console.WriteLine(result);
        }
    }
}

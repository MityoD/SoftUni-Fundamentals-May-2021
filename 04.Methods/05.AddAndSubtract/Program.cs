using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = Sum(a, b);
            int subtract = Subtract(sum, c);
            Console.WriteLine(subtract);
        }

        private static int Subtract(int sum, int c)
        {
            return sum - c;
        }

        private static int Sum(int a, int b)
        {
            return a + b;            
        }
    }
}

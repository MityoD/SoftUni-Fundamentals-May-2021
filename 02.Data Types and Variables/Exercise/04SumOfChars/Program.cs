using System;

namespace _04SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char num = char.Parse(Console.ReadLine());
                sum += (int)num;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}

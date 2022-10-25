using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;
            while (startingYield >= 100)
            {
                days++;
                totalAmount += startingYield;
                startingYield -= 10;
                totalAmount -= 26;
            }
            if (totalAmount > 0)
            {
                totalAmount -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}

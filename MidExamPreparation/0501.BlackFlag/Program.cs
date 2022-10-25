using System;

namespace _0501.BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPluner = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                double thirdDay = 1;
                double fifthDay = 1;
                if (i % 3 == 0)
                {
                    thirdDay = 1.5;
                }
                if (i % 5 == 0)
                {
                    fifthDay = 0.7;
                }
                totalPlunder += dailyPluner * thirdDay;
                totalPlunder *= fifthDay;
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder/expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}

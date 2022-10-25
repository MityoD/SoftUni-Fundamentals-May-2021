using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int snow = 0;
            int time = 0;
            BigInteger value = 0;
            int quality = 0;

            for (int i = 0; i < num; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > value)
                {
                    value = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }

            }
            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}

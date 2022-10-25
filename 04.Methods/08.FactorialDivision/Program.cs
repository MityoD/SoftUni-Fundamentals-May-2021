using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            FactorialDivision(firstNumber, secondNumber);
        }

        private static void FactorialDivision(int firstNumber, int secondNumber)
        {
            float firstFactoriel = 1;
            float secondFactoriel = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                firstFactoriel *= i;
            }
            for (int i = 1; i <= secondNumber; i++)
            {
                secondFactoriel *= i;
            }
            float sum = firstFactoriel / secondFactoriel;
            Console.WriteLine($"{sum:F2}");
        }
    }
}

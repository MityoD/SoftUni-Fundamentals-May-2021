using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0m;
            decimal apronsNeeded = Math.Ceiling(students * 1.2m);
            decimal freeFlour = students / 5;
            totalPrice = (students - freeFlour) * flourPrice + students * 10 * eggPrice + apronPrice * apronsNeeded;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {totalPrice:F2}$.") ;
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:F2}$ more needed.");
            }




        }
    }
}

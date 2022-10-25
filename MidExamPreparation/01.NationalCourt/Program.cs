using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {          
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());
            int peoplePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hoursCount = 0;
            while (totalPeople > 0)
            {
                totalPeople -= peoplePerHour;
                hoursCount++;
                if (hoursCount % 4 == 0)
                {
                    hoursCount++;
                }
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}

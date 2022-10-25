using System;

namespace _03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double result = Math.Ceiling((double)persons / capacity);
            Console.WriteLine(result);

        }
    }
}

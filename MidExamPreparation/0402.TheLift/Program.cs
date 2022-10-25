using System;
using System.Collections.Generic;
using System.Linq;

namespace _0402.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            List<int> liftState = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int liftMax = 4;
            for (int i = 0; i < liftState.Count; i++)
            {
                if (liftState[i] < liftMax && people > 0)
                {

                    int temp = liftMax - liftState[i];
                    if (people < liftMax)
                    {
                        temp = people;
                    }
                    liftState[i] += temp;
                    people -= temp;
                }
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            else if (people == 0 /*&& liftState.Sum() % 4 != 0*/) // two diferent tests banging
            {
                Console.WriteLine("The lift has empty spots!");
            }
            if (liftState.Sum() == 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            Console.WriteLine(string.Join(" ", liftState));

        }
    }
}

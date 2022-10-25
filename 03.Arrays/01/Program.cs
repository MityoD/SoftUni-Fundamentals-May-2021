using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] train = new int[num];
            for (int i = 0; i < num; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;

            }
            int totalPeople = 0;
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
                totalPeople += train[i];
            }
            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}

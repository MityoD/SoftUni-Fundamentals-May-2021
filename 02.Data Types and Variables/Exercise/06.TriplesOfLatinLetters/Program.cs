﻿using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + num; i++)
            {
                for (char j = 'a'; j < 'a' + num; j++)
                {
                    for (char k = 'a'; k <'a' + num; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}

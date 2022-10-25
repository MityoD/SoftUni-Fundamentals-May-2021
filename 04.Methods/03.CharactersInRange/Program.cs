using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            CharactersInRange(start, end);
        }

        private static void CharactersInRange(char start, char end)
        {
            
            if (start < end)
            {
                for (char i = (char)(start + 1); i < end; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (char i = (char)(end + 1); i < start; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

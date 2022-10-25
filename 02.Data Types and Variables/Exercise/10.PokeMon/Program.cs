using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactory = int.Parse(Console.ReadLine());//Y
            int originalValue = pokePower;
            int targetsPoked = 0;
            while (pokePower >= distance)
            {
                targetsPoked++;
                pokePower -= distance;
                if (pokePower == originalValue / 2 && exhaustionFactory > 0)
                {
                    pokePower /= exhaustionFactory;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}

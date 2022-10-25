using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            //abv>1>1>2>2asdasd
            string input = Console.ReadLine();
            int power = 0;
            string newString = "";
            int pwr = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {
                    power = int.Parse(input[i + 1].ToString());
                }
                while (power > 0)
                {

                    if (input[i + 1] != '>')
                    {
                        input = input.Replace(input[i + 1], '#');
                    }
                    else
                    {
                        power += input[i + 1];
                    }
                    power--;
                }


            }
        }
    }
}

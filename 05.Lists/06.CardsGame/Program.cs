using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<int> firstPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (firstPlayerDeck[i] > secondPlayerDeck[i])
                    {
                        int firstTemp = firstPlayerDeck[i];
                        int secondTemp = secondPlayerDeck[i];
                        firstPlayerDeck.RemoveAt(i);
                        secondPlayerDeck.RemoveAt(i);
                        firstPlayerDeck.Add(firstTemp);
                        firstPlayerDeck.Add(secondTemp);
                        break;
                    }
                    else if (firstPlayerDeck[i] < secondPlayerDeck[i])
                    {
                        int firstTemp = firstPlayerDeck[i];
                        int secondTemp = secondPlayerDeck[i];
                        firstPlayerDeck.RemoveAt(i);
                        secondPlayerDeck.RemoveAt(i);
                        secondPlayerDeck.Add(secondTemp);
                        secondPlayerDeck.Add(firstTemp);
                        break;
                    }
                    else if (firstPlayerDeck[i] == secondPlayerDeck[i])
                    {
                        firstPlayerDeck.RemoveAt(i);
                        secondPlayerDeck.RemoveAt(i);
                        break;
                    }
                }
            }
            if (firstPlayerDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");

            }
            else if (secondPlayerDeck.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");

            }
        }
    }
}

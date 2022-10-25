using System;
using System.Collections.Generic;
using System.Linq;

namespace _0202.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            int counter = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);
                int tempValue = 0;
                if (index < targets.Count && targets[index] >= 0)
                {
                    tempValue = targets[index];
                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] > tempValue && targets[i] >= 0)
                        {
                            targets[i] -= tempValue;
                        }
                        else if (targets[i] <= tempValue && targets[i] >= 0)
                        {
                            targets[i] += tempValue;
                        }
                    }
                    if (targets[index] >= 0)
                    {
                        targets[index] = -1;
                        counter++;
                    }

                }
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}
/*using System;
using System.Linq;

namespace ConsoleApp1
{
    class Exam
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int indexTarget = int.Parse(command);

                if (indexTarget >= 0 && indexTarget < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int temp = targets[indexTarget];

                        if (targets[i] != -1 && i != indexTarget)
                        {
                            if(targets[i] > temp)
                            {
                                targets[i] -= temp;
                            }
                            else if (targets[i] <= temp)
                            {
                                targets[i] += temp;

                            }
                        }
                    }
                    targets[indexTarget] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));
        }
    }
}*/
using System;
using System.Collections.Generic;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that keeps information about students and their grades. 
You will receive n pair of rows. First you will receive the student's name, after that you will receive his grade. Check if the student already exists and if not, add him. Keep track of all grades for each student.
When you finish reading the data, keep the students with average grade higher than or equal to 4.50. Order the filtered students by average grade in descending order.
Print the students and their average grade in the following format:
"{name} –> {averageGrade}"
Format the average grade to the 2nd decimal place.*/
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < num*2; i++)
            { string currentStudent = "";
                string input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    if (!students.ContainsKey(input))
                    {
                        students.Add(input, new List<double>());
                    }
                    currentStudent = input;
                }
                else
                {
                    double grade = double.Parse(input);
                    students[currentStudent].Add(grade);
                }
            }
            foreach (var item in students)
            {
            Console.WriteLine($"{item.Key} -> {item.Value:F2}");

            }
        }
    }
}

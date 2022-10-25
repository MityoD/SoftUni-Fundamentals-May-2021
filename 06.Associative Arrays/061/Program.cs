using System;
using System.Collections.Generic;
using System.Linq;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Input
	•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
	•	The product data is always delimited by " : ".
Output
	•	Print the information about each course in the following the format: "{courseName}: {registeredStudents}"
Print the information about each student, in the following the format:"-- {studentName}"*/
            string command = "";
            //List<string> myList = new List<string>();
            Dictionary<string, List<string>> allCourses = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" : ");
                string course = commandArgs[0];
                string student = commandArgs[1];
                if (!allCourses.ContainsKey(course))
                {
                    allCourses.Add(course, new List<string>());
                }
                allCourses[course].Add(student);
            }
            foreach (var item in allCourses.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
                foreach (var name in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");

                
                }
            }
        }
    }
}

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
            Dictionary<string, string> allCourses = new Dictionary<string, string>();

            while ((command = Console.ReadLine())!= "end")
            {
                string[] commandArgs = command.Split();
                string course = commandArgs[0];
                string student = commandArgs[1];
                if (!allCourses.ContainsKey(course))
                {
                    allCourses.Add(course, "");
                }
                allCourses[course] = student;
            }
            foreach (var (course, student) in allCourses.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{course} {student}");
            }
        }
    }
}

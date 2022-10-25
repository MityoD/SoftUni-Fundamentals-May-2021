using System;
using System.Collections.Generic;
using System.Linq;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will be receiving a company name and an employee's id, until you receive the command "End" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
When you finish reading the data, order the companies by the name in ascending order. 
Print the company name and each employee's id in the following format:
{companyName}
-- {id1}
-- {id2}
-- {idN}
Input / Constraints
	•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
	•	The input always will be valid.
*/
            Dictionary<string, List<string>> companyDB = new Dictionary<string, List<string>>();
            string command = "";
            while ((command = Console.ReadLine())!= "End")
            {
                string[] commandArgs = command.Split(" -> ");
                string companyName = commandArgs[0];
                string employeeId = commandArgs[1];
                if (!companyDB.ContainsKey(companyName))
                {
                    companyDB.Add(companyName, new List<string>());
                }
                if (!companyDB[companyName].Contains(employeeId))
                {
                    companyDB[companyName].Add(employeeId);
                }
            }
            foreach (var item in companyDB.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}

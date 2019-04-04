using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string depName = input[3];
                string email = "n/a";
                int age = -1;
                if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }
                if (input.Length == 5)
                {
                    int.TryParse(input[4], out age);
                    if (age == 0)
                    {
                        email = input[4];
                        age = -1;

                    }
                }
                if (!departments.Any(d => d.Name == depName))
                {
                    Department new_dep = new Department(depName);
                    departments.Add(new_dep);
                }
                Employee employee = new Employee(name, salary, position, email, age);
                var department = departments.FirstOrDefault(x => x.Name == depName);
                department.AddEmploee(employee);
            }
            var highestAvSalDep = departments.OrderByDescending(x => x.AverageSalary).First();
            Console.WriteLine("Highest Average Salary: " + highestAvSalDep.Name);
            foreach (var empl in highestAvSalDep.Employees.OrderByDescending(x => x.Salary))
                Console.WriteLine("{0} {1:f2} {2} {3}", empl.Name, empl.Salary, empl.Email, empl.Age);

        }
    }
}

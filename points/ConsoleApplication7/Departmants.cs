using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Department
    {
        private List<Employee> employees;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Department(string name)
    {
        employees = new List<Employee>();
        this.name = name;
    }
    public List<Employee> Employees 
    {
        get { return employees; }
        set { employees = value; } 
    }
    public decimal AverageSalary
    {
        get
        {
            return employees.Select(x => x.Salary).Average();
        }
    }
   

    public void AddEmploee(Employee employee)
    {
        employees.Add(employee);
    }
}

        
    }

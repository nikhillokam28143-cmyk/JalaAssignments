using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class LinqAssignments
{
    static void Main(string[] args)
    {
        List<Employee> employees = GetEmployees();


        Question1(employees);
        Question2(employees);
        Question3(employees);
        Question4(employees);
        Question5(employees);
        Question6(employees);
    }

    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee{EmpId=1,EmpName="Kishore",EmpSalary=1000,DeptId=1},
            new Employee{EmpId=2,EmpName="Ravi",EmpSalary=2500,DeptId=2},
            new Employee{EmpId=3,EmpName="Kishore",EmpSalary=1000,DeptId=2},
            new Employee{EmpId=4,EmpName="Rahul",EmpSalary=3000,DeptId=4},
            new Employee{EmpId=5,EmpName="Anil",EmpSalary=4000,DeptId=1},
            new Employee{EmpId=6,EmpName="Puja",EmpSalary=1500,DeptId=3},
            new Employee{EmpId=7,EmpName="David",EmpSalary=5000,DeptId=4},
            new Employee{EmpId=8,EmpName="Sita",EmpSalary=2200,DeptId=2},
            new Employee{EmpId=9,EmpName="John",EmpSalary=1800,DeptId=5},
            new Employee{EmpId=10,EmpName="Arun",EmpSalary=3500,DeptId=4}
        };

        return employees;
    }

    static void Print(List<Employee> list)
    {
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.EmpId + "  " +
                              emp.EmpName + "  " +
                              emp.EmpSalary + "  " +
                              emp.DeptId);
        }
    }

    // Question 1
    static void Question1(List<Employee> employees)
    {
        List<Employee> result =
            employees.Where(x => x.EmpName == "Kishore").ToList();

        Print(result);
    }

    // Question 2
    static void Question2(List<Employee> employees)
    {
        List<Employee> result =
            employees.Where(x => x.EmpId == 4).ToList();

        Print(result);
    }

    // Question 3
    static void Question3(List<Employee> employees)
    {
        List<Employee> result =
            employees.Where(x => x.DeptId == 4).ToList();

        Print(result);
    }

    // Question 4
    static void Question4(List<Employee> employees)
    {
        List<Employee> newList = employees.ToList();

        Print(newList);
    }

    // Question 5
    static void Question5(List<Employee> employees)
    {
        List<Employee> kishoreList =
            employees.Where(x => x.EmpName == "Kishore").ToList();

        Print(kishoreList);
    }

    // Question 6
    static void Question6(List<Employee> employees)
    {
        List<Employee> salaryList =
            employees.Where(x => x.EmpSalary > 2000).ToList();

        Console.WriteLine("Count = " + salaryList.Count);

        Print(salaryList);
    }
}
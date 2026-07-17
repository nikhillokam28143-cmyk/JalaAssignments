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

        Question13(employees);
        Question14(employees);
        Question15(employees);
        Question16(employees);
        Question17(employees);
    }

    static List<Employee> GetEmployees()
    {
        return new List<Employee>()
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
    }

    static void Print(List<Employee> list)
    {
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.EmpId + "\t" +
                              emp.EmpName + "\t" +
                              emp.EmpSalary + "\t" +
                              emp.DeptId);
        }
    }

    // 13. Single()
    static void Question13(List<Employee> employees)
    {
        Employee emp = employees.Single(x => x.EmpId == 4);

        Console.WriteLine(emp.EmpId + " " +
                          emp.EmpName + " " +
                          emp.EmpSalary + " " +
                          emp.DeptId);
    }

    // 14. SingleOrDefault()
    static void Question14(List<Employee> employees)
    {
        Employee emp = employees.SingleOrDefault(x => x.EmpId == 4);

        if (emp != null)
        {
            Console.WriteLine(emp.EmpId + " " +
                              emp.EmpName + " " +
                              emp.EmpSalary + " " +
                              emp.DeptId);
        }
    }

    // 15. OrderBy EmpId
    static void Question15(List<Employee> employees)
    {
        List<Employee> result = employees
            .OrderBy(x => x.EmpId)
            .ToList();

        Print(result);
    }

    // 16. OrderBy EmpName
    static void Question16(List<Employee> employees)
    {
        List<Employee> result = employees
            .OrderBy(x => x.EmpName)
            .ToList();

        Print(result);
    }

    // 17. Sort by EmpName, then reverse by EmpId
    static void Question17(List<Employee> employees)
    {
        employees.Sort(delegate (Employee x, Employee y)
        {
            int result = x.EmpName.CompareTo(y.EmpName);

            if (result == 0)
            {
                return y.EmpId.CompareTo(x.EmpId);
            }

            return result;
        });

        Print(employees);
    }
}
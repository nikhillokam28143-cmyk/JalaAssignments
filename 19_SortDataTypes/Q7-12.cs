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


        Question7(employees);
        Question8(employees);
        Question9(employees);
        Question10();
        Question11(employees);
        Question12(employees);
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

    // 7. Employees with DeptId = 4
    static void Question7(List<Employee> employees)
    {
        List<Employee> result = employees
            .Where(x => x.DeptId == 4)
            .ToList();

        Print(result);
    }

    // 8. Check DeptId = 4 using Contains (Any is more appropriate)
    static void Question8(List<Employee> employees)
    {
        bool exists = employees.Any(x => x.DeptId == 4);

        Console.WriteLine("Department 4 Exists : " + exists);

        if (exists)
        {
            List<Employee> result =
                employees.Where(x => x.DeptId == 4).ToList();

            Print(result);
        }
    }

    // 9. Distinct Employee Names
    static void Question9(List<Employee> employees)
    {
        var names = employees
            .Select(x => x.EmpName)
            .Distinct();

        Console.WriteLine("Distinct Employee Count : " + names.Count());

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    // 10. Array to List
    static void Question10()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        List<int> list = numbers.ToList();

        foreach (int number in list)
        {
            Console.WriteLine(number);
        }
    }

    // 11. First()
    static void Question11(List<Employee> employees)
    {
        Employee emp = employees.First();

        Console.WriteLine(emp.EmpId + " " +
                          emp.EmpName + " " +
                          emp.EmpSalary + " " +
                          emp.DeptId);
    }

    // 12. FirstOrDefault()
    static void Question12(List<Employee> employees)
    {
        Employee emp = employees.FirstOrDefault();

        if (emp != null)
        {
            Console.WriteLine(emp.EmpId + " " +
                              emp.EmpName + " " +
                              emp.EmpSalary + " " +
                              emp.DeptId);
        }
    }
}
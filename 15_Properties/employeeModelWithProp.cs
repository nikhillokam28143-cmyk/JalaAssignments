using System;

class PropertyAssignments
{
    static void Main(string[] args)
    {

        ReadOnlyProperty();
        ReadWriteProperty();
        EmployeeObjectOne();
        EmployeeObjectTwo();
    }

    // 1. Read-Only Property
    static void ReadOnlyProperty()
    {
        Employee employee = new Employee();

        Console.WriteLine("Employee ID : " + employee.EmpId);
    }

    // 2. Read and Write Property
    static void ReadWriteProperty()
    {
        Employee employee = new Employee();

        employee.EmpName = "Puja";

        Console.WriteLine("Employee Name : " + employee.EmpName);
    }

    // 4. First Employee Object
    static void EmployeeObjectOne()
    {
        EmployeeModel emp1 = new EmployeeModel();

        emp1.EmpId = 101;
        emp1.EmpName = "Puja";
        emp1.EmailId = "puja@gmail.com";
        emp1.Salary = 35000;
        emp1.IsEmployeeActive = true;

        PrintEmployee(emp1);
    }

    // 5. Second Employee Object
    static void EmployeeObjectTwo()
    {
        EmployeeModel emp2 = new EmployeeModel();

        emp2.EmpId = 102;
        emp2.EmpName = "Rahul";
        emp2.EmailId = "rahul@gmail.com";
        emp2.Salary = 45000;
        emp2.IsEmployeeActive = false;

        PrintEmployee(emp2);
    }

    static void PrintEmployee(EmployeeModel emp)
    {
        Console.WriteLine("Employee ID      : " + emp.EmpId);
        Console.WriteLine("Employee Name    : " + emp.EmpName);
        Console.WriteLine("Email ID         : " + emp.EmailId);
        Console.WriteLine("Salary           : " + emp.Salary);
        Console.WriteLine("Employee Active  : " + emp.IsEmployeeActive);
    }
}

// Class for Read-Only and Read-Write Properties
class Employee
{
    // Read-Only Property
    public int EmpId
    {
        get
        {
            return 101;
        }
    }

    // Read and Write Property
    private string empName;

    public string EmpName
    {
        get
        {
            return empName;
        }
        set
        {
            empName = value;
        }
    }
}

// EmployeeModel Class
class EmployeeModel
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmailId { get; set; }
    public float Salary { get; set; }
    public bool IsEmployeeActive { get; set; }
}
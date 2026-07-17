using System;

class ClassAssignments
{
    // Fields for Car
    string color;
    int maxSpeed;

    // Constructor 1 (Default)
    public ClassAssignments()
    {
        color = "Red";
        maxSpeed = 180;
    }

    // Constructor 2 (Parameterized)
    public ClassAssignments(string name, int age)
    {
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Employee Age  : " + age);
    }

    static void Main(string[] args)
    {

        EmployeeDetails();
        ConstructorOverloading();
        CarClass();
        CarObject();
        MultipleObjects();
    }

    // 1. Employee Details using Parameters
    static void EmployeeDetails()
    {
        string empName;
        int empId;
        double salary;

        Console.Write("Enter Employee ID: ");
        empId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        empName = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        PrintEmployee(empId, empName, salary);
    }

    static void PrintEmployee(int id, string name, double salary)
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Employee Name : " + name);
        Console.WriteLine("Salary : " + salary);
    }

    // 2. Constructor Overloading
    static void ConstructorOverloading()
    {
        ClassAssignments obj1 = new ClassAssignments();

        ClassAssignments obj2 = new ClassAssignments("Puja", 24);
    }

    // 3. Car class members, fields and method
    static void CarClass()
    {
        ClassAssignments car = new ClassAssignments();

        car.DisplayCar();
    }

    void DisplayCar()
    {
        Console.WriteLine("Car Color : " + color);
        Console.WriteLine("Car Max Speed : " + maxSpeed);
    }

    // 4. Create object myObj and print fields
    static void CarObject()
    {
        ClassAssignments myObj = new ClassAssignments();

        Console.WriteLine("Color : " + myObj.color);
        Console.WriteLine("Max Speed : " + myObj.maxSpeed);
    }

    // 5. Multiple Objects
    static void MultipleObjects()
    {
        ClassAssignments car1 = new ClassAssignments();
        ClassAssignments car2 = new ClassAssignments();

        Console.WriteLine("Car 1");
        Console.WriteLine("Color : " + car1.color);
        Console.WriteLine("Max Speed : " + car1.maxSpeed);

        Console.WriteLine();

        Console.WriteLine("Car 2");
        Console.WriteLine("Color : " + car2.color);
        Console.WriteLine("Max Speed : " + car2.maxSpeed);
    }
}
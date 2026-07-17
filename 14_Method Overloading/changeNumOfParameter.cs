using System;

class OverloadingAssignments
{
    static void Main(string[] args)
    {

        OverloadingByNumberOfParameters();
        OverloadingByOrderOfParameters();
        SumFunction();
        DivisionFunction();
    }

    // 1. Method Overloading by changing the Number of Parameters
    static void OverloadingByNumberOfParameters()
    {
        Add(10, 20);
        Add(10, 20, 30);
    }

    static void Add(int a, int b)
    {
        Console.WriteLine("Sum of Two Numbers : " + (a + b));
    }

    static void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum of Three Numbers : " + (a + b + c));
    }

    // 2. Method Overloading by changing the Order of Parameters
    static void OverloadingByOrderOfParameters()
    {
        Display(100, "JALA");
        Display("JALA", 100);
    }

    static void Display(int id, string name)
    {
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Name : " + name);
    }

    static void Display(string name, int id)
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("ID : " + id);
    }

    // 3. Sum() Function
    static void SumFunction()
    {
        int a, b;

        Console.Write("Enter First Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Sum(a, b);
    }

    static void Sum(int a, int b)
    {
        Console.WriteLine("Sum = " + (a + b));
    }

    // 4. Division() Function
    static void DivisionFunction()
    {
        int a, b;

        Console.Write("Enter Dividend: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Divisor: ");
        b = Convert.ToInt32(Console.ReadLine());

        Division(a, b);
    }

    static void Division(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Division = " + (a / b));
        }
        else
        {
            Console.WriteLine("Division by Zero is not Allowed.");
        }
    }
}
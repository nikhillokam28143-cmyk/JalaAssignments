using System;

class MethodAssignments
{
    static void Main(string[] args)
    {

        BooleanWriteLine();
        StaticAndInstanceMethods();
        Calculator();
        ParameterArray();
        PrintEvenNumbers();
    }

    // 1. Using WriteLine(Boolean)
    static void BooleanWriteLine()
    {
        bool result = true;

        Console.WriteLine(result);
    }

    // 2. Static and Instance Methods
    static void StaticAndInstanceMethods()
    {
        Console.WriteLine("Calling Static Method");
        StaticMethod();

        MethodAssignments obj = new MethodAssignments();

        Console.WriteLine("Calling Instance Method");
        obj.InstanceMethod();
    }

    static void StaticMethod()
    {
        Console.WriteLine("This is Static Method");
    }

    void InstanceMethod()
    {
        Console.WriteLine("This is Instance Method");
    }

    // 3. Calculator (Sum and Product)
    static void Calculator()
    {
        int a, b;

        Console.Write("Enter First Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Sum(a, b);
        Product(a, b);
    }

    static void Sum(int a, int b)
    {
        Console.WriteLine("Sum = " + (a + b));
    }

    static void Product(int a, int b)
    {
        Console.WriteLine("Product = " + (a * b));
    }

    // 4. Parameter Array
    static void ParameterArray()
    {
        PrintNumbers(10, 20, 30, 40, 50);
    }

    static void PrintNumbers(params int[] numbers)
    {
        Console.WriteLine("Numbers are:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    // 5. Print entered number of even numbers
    static void PrintEvenNumbers()
    {
        int n;
        int even = 2;

        Console.Write("Enter Number: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even Numbers:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(even + " ");
            even = even + 2;
        }

        Console.WriteLine();
    }
}
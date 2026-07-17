using System;

class OperatorsAssignments
{
    static void Main(string[] args)
    {

        BinaryArithmeticOperators();
        UnaryArithmeticOperators();
        RelationalOperators();
    }

    // 1. Binary Arithmetic Operators
    static void BinaryArithmeticOperators()
    {
        int a, b;

        Console.Write("Enter First Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition Operator: " + (a + b));
        Console.WriteLine("Subtraction Operator: " + (a - b));
        Console.WriteLine("Multiplication Operator: " + (a * b));
        Console.WriteLine("Division Operator: " + (a / b));
        Console.WriteLine("Modulo Operator: " + (a % b));
    }

    // 2. Unary Arithmetic Operators
    static void UnaryArithmeticOperators()
    {
        int a, res;

        Console.Write("Enter a Value: ");
        a = Convert.ToInt32(Console.ReadLine());

        res = a++;
        Console.WriteLine("a++ : a = " + a + " , res = " + res);

        res = a--;
        Console.WriteLine("a-- : a = " + a + " , res = " + res);

        res = ++a;
        Console.WriteLine("++a : a = " + a + " , res = " + res);

        res = --a;
        Console.WriteLine("--a : a = " + a + " , res = " + res);
    }

    // 3. Relational Operators
    static void RelationalOperators()
    {
        int a, b;

        Console.Write("Enter First Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Equal To Operator: " + (a == b));
        Console.WriteLine("Greater Than Operator: " + (a > b));
        Console.WriteLine("Less Than Operator: " + (a < b));
        Console.WriteLine("Greater Than Or Equal To Operator: " + (a >= b));
        Console.WriteLine("Less Than Or Equal To Operator: " + (a <= b));
        Console.WriteLine("Not Equal To Operator: " + (a != b));
    }
}
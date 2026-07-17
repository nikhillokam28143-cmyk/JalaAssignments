using System;

class basicAssignments
{
    static void Main(string[] args)
    {

        EmployeeDetails();
        OddEven();
        SwapNumbers();
    }

    // Program 1-4
    static void EmployeeDetails()
    {
        int empID;
        string empName;

        empID = 5;
        empName = "Puja";

        Console.WriteLine("Employee ID : " + empID);
        Console.WriteLine("Employee Name : " + empName);
    }

    // Program 5
    static void OddEven()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }

    // Program 6
    static void SwapNumbers()
    {
        int firstNumber, secondNumber, temp;

        Console.Write("Enter first number: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("First Number : " + firstNumber);
        Console.WriteLine("Second Number : " + secondNumber);
    }
}
using System;

class StringAssignments
{
    static void Main(string[] args)
    {
        printemployeename();
        readandprintname();
        enteryourname();
        concatenatestrings();
        addtwonumbers();
        PasswordToString();
    }

    // 1. Create any value called EmpName and print it
    static void PrintEmployeeName()
    {
        string EmpName = "Puja";

        Console.WriteLine("Employee Name : " + EmpName);
    }

    // 2. Declare a variable and read the name
    static void ReadAndPrintName()
    {
        string name;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Name : " + name);
    }

    // 3. Enter your name and print using WriteLine
    static void EnterYourName()
    {
        string name;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Hello " + name);
    }

    // 4. Concatenate two strings
    static void ConcatenateStrings()
    {
        string firstName;
        string lastName;
        string message;

        Console.Write("Enter First Name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        lastName = Console.ReadLine();

        message = "Hello " + firstName + " " + lastName;

        Console.WriteLine(message);
    }

    // 5. Add two integers
    static void AddTwoNumbers()
    {
        int number1, number2, sum;

        Console.Write("Enter First Number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine("Sum = " + sum);
    }

    // 6. Convert password char array to string
    static void PasswordToString()
    {
        char[] password = new char[20];
        int i = 0;

        Console.Write("Enter Password: ");

        while (true)
        {
            char ch = Console.ReadKey().KeyChar;

            if (ch == '\r')
            {
                break;
            }

            password[i] = ch;
            i++;
        }

        Console.WriteLine();

        string result = "";

        for (int j = 0; j < i; j++)
        {
            result = result + password[j];
        }

        Console.WriteLine("Password : " + result);
    }
}
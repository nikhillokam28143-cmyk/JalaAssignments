using System;

class DataTypeAssignments
{
    static void Main(string[] args)
    {

        PrintInteger();
        BooleanProgram();
        FloatToDecimal();
        Calculator();
        ReverseLetters();
        CheckCharacter();
    }

    // 1. Declare an int value and print it
    static void PrintInteger()
    {
        int number = 100;

        Console.WriteLine("Integer Value : " + number);
    }

    // 2. Boolean type program
    static void BooleanProgram()
    {
        bool result = true;

        Console.WriteLine("Boolean Value : " + result);
    }

    // 3. Convert Float to Decimal
    static void FloatToDecimal()
    {
        float number = 25.75f;
        decimal value;

        value = (decimal)number;

        Console.WriteLine("Float Value   : " + number);
        Console.WriteLine("Decimal Value : " + value);
    }

    // 4. Perform arithmetic operations
    static void Calculator()
    {
        int firstNumber, secondNumber;
        char operation;

        Console.Write("Enter First Number: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Operation (+,-,*,/): ");
        operation = Convert.ToChar(Console.ReadLine());

        if (operation == '+')
        {
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
        }
        else if (operation == '-')
        {
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
        }
        else if (operation == '*')
        {
            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
        }
        else if (operation == '/')
        {
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
        }
        else
        {
            Console.WriteLine("Invalid Operation");
        }
    }

    // 5. Reverse three letters
    static void ReverseLetters()
    {
        char firstLetter, secondLetter, thirdLetter;

        Console.Write("Enter First Letter: ");
        firstLetter = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Second Letter: ");
        secondLetter = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Third Letter: ");
        thirdLetter = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Reverse Order : " + thirdLetter + " " + secondLetter + " " + firstLetter);
    }

    // 6. Check vowel, digit or symbol
    static void CheckCharacter()
    {
        char ch;

        Console.Write("Enter a Character: ");
        ch = Convert.ToChar(Console.ReadLine());

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("It is a lowercase vowel");
        }
        else if (ch >= '0' && ch <= '9')
        {
            Console.WriteLine("It is a digit");
        }
        else
        {
            Console.WriteLine("It is another symbol");
        }
    }
}
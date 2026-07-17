using System;

class ConditionalStatements
{
    static void Main(string[] args)
    {

        PositiveOrNegative();
        LeapYear();
        VowelOrConsonant();
    }

    // 1. Check whether a number is positive or negative
    static void PositiveOrNegative()
    {
        int number;

        Console.Write("Enter a Number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine(number + " is a Positive Number");
        }
        else if (number < 0)
        {
            Console.WriteLine(number + " is a Negative Number");
        }
        else
        {
            Console.WriteLine("The Number is Zero");
        }
    }

    // 2. Check whether a year is a leap year
    static void LeapYear()
    {
        int year;

        Console.Write("Enter a Year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is Not a Leap Year");
        }
    }

    // 3. Check whether an alphabet is a vowel or consonant
    static void VowelOrConsonant()
    {
        char alphabet;

        Console.Write("Enter an Alphabet: ");
        alphabet = Convert.ToChar(Console.ReadLine());

        if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' ||
            alphabet == 'o' || alphabet == 'u' ||
            alphabet == 'A' || alphabet == 'E' || alphabet == 'I' ||
            alphabet == 'O' || alphabet == 'U')
        {
            Console.WriteLine("The Alphabet is a Vowel");
        }
        else
        {
            Console.WriteLine("The Alphabet is a Consonant");
        }
    }
}
```

### To

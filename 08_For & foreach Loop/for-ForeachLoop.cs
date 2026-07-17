using System;

class LoopAssignments
{
    static void Main(string[] args)
    {
        NaturalNumbers();
        OddNaturalNumbers();
        ArrayForAndForeach();
    }

    // 1. Display n natural numbers and their sum
    static void NaturalNumbers()
    {
        int n, sum = 0;

        Console.Write("Enter number of natural terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The first " + n + " natural numbers are:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum = sum + i;
        }

        Console.WriteLine();
        Console.WriteLine("The Sum of Natural Numbers up to " + n + " terms: " + sum);
    }

    // 2. Display n odd natural numbers and their sum
    static void OddNaturalNumbers()
    {
        int n, sum = 0, number = 1;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The odd numbers are:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(number + " ");
            sum = sum + number;
            number = number + 2;
        }

        Console.WriteLine();
        Console.WriteLine("The Sum of Odd Natural Numbers up to " + n + " terms: " + sum);
    }

    // 3. Print array using For loop and Foreach loop
    static void ArrayForAndForeach()
    {
        string[] company = { "Jala", "Technologies" };

        Console.WriteLine("Printing Array using For Loop:");

        for (int i = 0; i < company.Length; i++)
        {
            Console.Write(company[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Printing Array using Foreach Loop:");

        foreach (string item in company)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    }
}
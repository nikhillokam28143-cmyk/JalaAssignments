using System;

class TypeConversionAssignments
{
    static void Main(string[] args)
    {

        ImplicitTypeConversion();
        ExplicitTypeConversion();
        BuiltInTypeConversion();
        ValueToStringConversion();
    }

    // 1. Implicit Type Conversion
    static void ImplicitTypeConversion()
    {
        int intValue;
        long longValue;

        Console.Write("Enter Int Value: ");
        intValue = Convert.ToInt32(Console.ReadLine());

        longValue = intValue; // Implicit Conversion

        Console.WriteLine("Int Value  : " + intValue);
        Console.WriteLine("Long Value : " + longValue);
    }

    // 2. Explicit Type Conversion
    static void ExplicitTypeConversion()
    {
        double d;

        Console.Write("Enter Value: ");
        d = Convert.ToDouble(Console.ReadLine());

        int i = (int)d; // Explicit Conversion

        Console.WriteLine("Value of I is " + i);
    }

    // 3. Built-in Type Conversion Methods
    static void BuiltInTypeConversion()
    {
        string strValue;
        int intValue;

        Console.Write("Enter String Number: ");
        strValue = Console.ReadLine();

        Console.Write("Enter Integer Value: ");
        intValue = Convert.ToInt32(Console.ReadLine());

        float floatValue = Convert.ToSingle(strValue);
        double doubleValue = Convert.ToDouble(intValue);

        Console.WriteLine("String to Float : " + floatValue);
        Console.WriteLine("Int to Double   : " + doubleValue);
    }

    // 4. Convert Value Types to String
    static void ValueToStringConversion()
    {
        int intValue;
        float floatValue;

        Console.Write("Enter Integer Value: ");
        intValue = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Float Value: ");
        floatValue = Convert.ToSingle(Console.ReadLine());

        string str1 = intValue.ToString();
        string str2 = floatValue.ToString();

        Console.WriteLine("int.ToString()   : " + str1);
        Console.WriteLine("float.ToString() : " + str2);
    }
}
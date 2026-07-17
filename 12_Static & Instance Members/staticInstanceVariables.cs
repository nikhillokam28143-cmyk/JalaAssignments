using System;

class StaticAssignments
{
    // Static Variable
    static int number = 100;

    // Instance Variable
    int value = 50;

    // Static Constructor
    static StaticAssignments()
    {
        Console.WriteLine("Static Constructor Executed");
        number = 200;
    }

    // Instance Constructor
    public StaticAssignments()
    {
        Console.WriteLine("Instance Constructor Executed");
        Console.WriteLine("Instance Value : " + value);
    }

    static void Main(string[] args)
    {

        AccessStaticVariable();
        AccessStaticMethod();
        ConstructorsDemo();
        ChangeStaticVariable();
    }

    // 1. Access Static Variable through Class Name
    static void AccessStaticVariable()
    {
        Console.WriteLine("Static Variable : " + StaticAssignments.number);
    }

    // 2. Access Static Method through an Instance
    static void AccessStaticMethod()
    {
        StaticAssignments obj = new StaticAssignments();

        obj.ShowMessage();
    }

    static void ShowMessage()
    {
        Console.WriteLine("This is a Static Method");
    }

    // 3. Static and Instance Constructors
    static void ConstructorsDemo()
    {
        StaticAssignments obj = new StaticAssignments();
    }

    // 4. Change Static Variable within the Class
    static void ChangeStaticVariable()
    {
        Console.WriteLine("Before Change : " + number);

        number = 500;

        Console.WriteLine("After Change : " + number);
    }
}
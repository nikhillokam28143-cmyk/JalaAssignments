using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class ListAssignments
{
    static void Main(string[] args)
    {
        IntegerList();
        StringList();
        StudentList();
    }

    // 1 & 2 - Properties and Methods
    // Properties:
    // Count
    // Capacity
    // Item[Index]
    // IsReadOnly
    // Comparer

    // Methods:
    // Add()
    // Clear()
    // Insert()
    // RemoveAt()
    // Reverse()

    static void IntegerList()
    {
        List<int> numbers = new List<int>();

        // 3. Add 5 integers
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // 4. For Loop
        Console.WriteLine("Using For Loop");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();

        // 5. Foreach Loop
        Console.WriteLine("Using Foreach Loop");
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();

        // 9
        Console.WriteLine("Count = " + numbers.Count);

        // 10
        numbers.Clear();
        Console.WriteLine("Count After Clear = " + numbers.Count);
    }

    static void StringList()
    {
        List<string> names = new List<string>();

        // 6
        names.Add("Ravi");
        names.Add("Kishore");
        names.Add("Puja");
        names.Add("Rahul");
        names.Add("Anil");

        // 7
        Console.WriteLine("\nStrings Using For");
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        // 8
        Console.WriteLine("\nStrings Using Foreach");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 11
        Console.WriteLine("Exists : " + names.Exists(x => x == "Kishore"));

        // 12
        Console.WriteLine("Find : " + names.Find(x => x == "Kishore"));

        // 13
        Console.WriteLine("Contains : " + names.Contains("Kishore"));

        // 14
        names.Insert(2, "JALA");

        // 15
        names.Reverse();

        Console.WriteLine("\nAfter Reverse");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 16
        names.RemoveAt(3);

        Console.WriteLine("\nAfter RemoveAt(3)");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void StudentList()
    {
        List<Student> students = new List<Student>();

        // 18
        for (int i = 1; i <= 10; i++)
        {
            Student s = new Student();
            s.Id = i;
            s.Name = "Student" + i;

            students.Add(s);
        }

        Console.WriteLine("\nStudent List");

        foreach (Student s in students)
        {
            Console.WriteLine(s.Id + " " + s.Name);
        }

        // 19
        Console.WriteLine("Student Count = " + students.Count);

        // 20
        students.Clear();

        Console.WriteLine("Count After Clear = " + students.Count);
    }
}
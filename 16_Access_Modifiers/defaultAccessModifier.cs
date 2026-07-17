using System;

class Student
{
    // 1. Public Access Modifier
    public int StudentId = 101;
    public string StudentName = "Santhi";

    // 2. Protected Access Modifier
    protected int x = 10;

    protected void DisplayProtected()
    {
        Console.WriteLine("Protected Value : " + x);
    }

    // 3. Private Access Modifier
    private int age = 20;

    public void DisplayPrivate()
    {
        Console.WriteLine("Private Value : " + age);
    }

    // 4. Default (Internal) Access Modifier
    int marks = 95;

    public void DisplayDefault()
    {
        Console.WriteLine("Default Value : " + marks);
    }
}

// Derived Class
class StudentDetails : Student
{
    public void ShowProtected()
    {
        DisplayProtected();
    }
}

class AccessModifierAssignments
{
    static void Main(string[] args)
    {

        PublicAccessModifier();
        ProtectedAccessModifier();
        PrivateAccessModifier();
        DefaultAccessModifier();
    }

    // 1. Public Access Modifier
    static void PublicAccessModifier()
    {
        Student student = new Student();

        Console.WriteLine("Student ID : " + student.StudentId);
        Console.WriteLine("Student Name : " + student.StudentName);
    }

    // 2. Protected Access Modifier
    static void ProtectedAccessModifier()
    {
        StudentDetails obj = new StudentDetails();

        obj.ShowProtected();
    }

    // 3. Private Access Modifier
    static void PrivateAccessModifier()
    {
        Student student = new Student();

        student.DisplayPrivate();
    }

    // 4. Default (Internal) Access Modifier
    static void DefaultAccessModifier()
    {
        Student student = new Student();

        student.DisplayDefault();
    }
}
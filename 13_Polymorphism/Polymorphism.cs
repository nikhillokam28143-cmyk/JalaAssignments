using System;

class PolymorphismAssignments
{
    static void Main(string[] args)
    {

        MethodOverloading();
        RuntimePolymorphism();
        DifferentSignature();
        OverloadingDataTypes();
        OverloadingParameterOrder();
    }

    // 1. Method Overloading (Two and Three Parameters)
    static void MethodOverloading()
    {
        Add(10, 20);
        Add(10, 20, 30);
    }

    static void Add(int a, int b)
    {
        Console.WriteLine("Sum of Two Numbers : " + (a + b));
    }

    static void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum of Three Numbers : " + (a + b + c));
    }

    // 2. Runtime Polymorphism
    static void RuntimePolymorphism()
    {
        Animal animal = new Dog();
        animal.Sound();
    }

    // Base Class
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived Class
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // 3. Same Method Name with Different Signatures
    static void DifferentSignature()
    {
        Display(100);
        Display("JALA");
        Display(25.5);
    }

    static void Display(int number)
    {
        Console.WriteLine("Integer Value : " + number);
    }

    static void Display(string text)
    {
        Console.WriteLine("String Value : " + text);
   
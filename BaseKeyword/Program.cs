using System;

// Base Class
class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor called");
    }
}

// Derived Class
class Dog : Animal
{
    public Dog() : base()  // Calls the base class constructor
    {
        Console.WriteLine("Dog constructor called");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();  // Creates an object of Dog
    }
}


// This program demonstrates fields and instance variables
using System;

class Person
{
    // Field or instance variable
    public string name;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {name}");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.name = "Alice"; // Assign value to instance variable
        p.Introduce(); // Call method using instance variable
    }
}

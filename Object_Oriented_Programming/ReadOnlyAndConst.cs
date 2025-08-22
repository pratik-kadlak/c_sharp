using System;

public class Circle
{
    // const field: must be assigned at declaration and cannot be changed
    // It's implicitly static and shared across all instances
    public const double Pi = 3.14159;

    // readonly field: can be assigned at declaration or in the constructor
    // Value can differ per instance but cannot be changed after construction
    public readonly double Radius;

    // Constructor to initialize readonly field
    public Circle(double radius)
    {
        Radius = radius; // Allowed: readonly can be set in constructor
    }

    // Method to calculate area using const and readonly
    public double GetArea()
    {
        return Pi * Radius * Radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        Circle c2 = new Circle(10);

        Console.WriteLine($"Circle 1 Radius: {c1.Radius}, Area: {c1.GetArea()}");
        Console.WriteLine($"Circle 2 Radius: {c2.Radius}, Area: {c2.GetArea()}");

        // Accessing const directly via class name (since it's static)
        Console.WriteLine($"Value of Pi (const): {Circle.Pi}");

        // Trying to modify const or readonly will result in compile-time error
        // Circle.Pi = 3.14;       // ❌ Not allowed
        // c1.Radius = 7;          // ❌ Not allowed
    }
}

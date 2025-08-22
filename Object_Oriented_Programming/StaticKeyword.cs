using System;

// Static class: can only contain static members
// Cannot be instantiated
public static class MathUtilities
{
    // Static method: belongs to the class, not to an instance
    public static int Square(int number)
    {
        return number * number;
    }

    // Static variable: shared across all usages
    public static int CallCount = 0;

    public static void IncrementCallCount()
    {
        CallCount++;
    }
}

// Regular class with static and non-static members
public class Counter
{
    // Static variable: shared across all instances
    public static int GlobalCount = 0;

    // Instance variable: unique to each object
    public int InstanceCount = 0;

    // Static method: can access only static members
    public static void IncrementGlobal()
    {
        GlobalCount++;
    }

    // Instance method: can access both static and instance members
    public void IncrementInstance()
    {
        InstanceCount++;
        GlobalCount++; // Can also access static members
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Using static class and static method
        int result = MathUtilities.Square(5);
        Console.WriteLine($"Square of 5: {result}");

        // Using static variable from static class
        MathUtilities.IncrementCallCount();
        MathUtilities.IncrementCallCount();
        Console.WriteLine($"MathUtilities CallCount: {MathUtilities.CallCount}");

        // Using static and instance members from regular class
        Counter c1 = new Counter();
        Counter c2 = new Counter();

        c1.IncrementInstance();
        c2.IncrementInstance();
        Counter.IncrementGlobal(); // Static method call

        Console.WriteLine($"c1 InstanceCount: {c1.InstanceCount}");
        Console.WriteLine($"c2 InstanceCount: {c2.InstanceCount}");
        Console.WriteLine($"GlobalCount (shared): {Counter.GlobalCount}");
    }
}

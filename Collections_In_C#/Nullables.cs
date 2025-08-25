using System;

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ Declaring a regular int variable (cannot be null)
        int regularNumber = 10;

        // ✅ Declaring a nullable int variable using '?'
        int? nullableNumber = null;

        // ✅ Checking if the nullable variable has a value
        if (nullableNumber.HasValue)
        {
            Console.WriteLine($"Nullable number has value: {nullableNumber.Value}");
        }
        else
        {
            Console.WriteLine("Nullable number is null.");
        }

        // ✅ Assigning a value later
        nullableNumber = 25;

        // ✅ Using null-coalescing operator (??) to provide a default value
        int result = nullableNumber ?? 0;
        Console.WriteLine($"Result using null-coalescing: {result}");

        // ✅ Nullable types can be used with other value types too
        bool? isAvailable = null;
        Console.WriteLine($"Is Available: {(isAvailable ?? false)}"); // Default to false if null
    }
}
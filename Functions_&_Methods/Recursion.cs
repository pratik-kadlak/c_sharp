
// Recursion.cs
// This program introduces the concept of recursion in C# and provides examples with explanations.

// -----------------------------
// 📘 Introduction to Recursion
// -----------------------------
// Recursion is a programming technique where a method calls itself to solve a problem.
// It is useful for problems that can be broken down into smaller, similar sub-problems.
// Every recursive method must have a base case to avoid infinite recursion.

using System;

class RecursionExamples
{
    // -----------------------------
    // Example 1: Factorial Function
    // -----------------------------
    // Calculates factorial of a number using recursion.
    // factorial(n) = n * factorial(n - 1)
    // Base case: factorial(0) = 1

    public static int Factorial(int n)
    {
        if (n == 0)
            return 1; // base case
        else
            return n * Factorial(n - 1); // recursive call
    }

    // -----------------------------
    // Example 2: Fibonacci Sequence
    // -----------------------------
    // Returns the nth Fibonacci number.
    // fibonacci(n) = fibonacci(n - 1) + fibonacci(n - 2)
    // Base cases: fibonacci(0) = 0, fibonacci(1) = 1

    public static int Fibonacci(int n)
    {
        if (n == 0)
            return 0; // base case
        else if (n == 1)
            return 1; // base case
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); // recursive call
    }

    // -----------------------------
    // Example 3: Sum of Array Elements
    // -----------------------------
    // Recursively calculates the sum of elements in an array.

    public static int SumArray(int[] arr, int index)
    {
        if (index < 0)
            return 0; // base case
        else
            return arr[index] + SumArray(arr, index - 1); // recursive call
    }

    // -----------------------------
    // Main Method to Demonstrate Recursion
    // -----------------------------
    static void Main(string[] args)
    {
        Console.WriteLine("Recursion Examples in C#");

        // Factorial Example
        int num = 5;
        Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");

        // Fibonacci Example
        int fibIndex = 6;
        Console.WriteLine($"Fibonacci number at position {fibIndex} is: {Fibonacci(fibIndex)}");

        // Sum of Array Example
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Sum of array elements is: {SumArray(numbers, numbers.Length - 1)}");
    }
}

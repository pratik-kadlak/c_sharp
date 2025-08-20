// This program introduces functions in C#
using System;

class Program
{
    // A simple function that returns the sum of two integers
    static int Add(int a, int b)
    {
        return a + b; // Return the result of addition
    }

    static void Main()
    {
        int result = Add(5, 3); // Call the Add function
        Console.WriteLine($"Sum: {result}");
    }
}

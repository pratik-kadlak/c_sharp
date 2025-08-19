// This program demonstrates how to declare and use a simple array to store multiple values of the same type.
using System;

class Program
{
    static void Main()
    {
        // Simple array example
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

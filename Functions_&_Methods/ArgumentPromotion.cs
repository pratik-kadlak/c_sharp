// This program demonstrates argument promotion
using System;

class Program
{
    static void PrintDouble(double value)
    {
        Console.WriteLine($"Double value: {value}");
    }

    static void Main()
    {
        int intValue = 5;
        PrintDouble(intValue); // int is promoted to double
    }
}

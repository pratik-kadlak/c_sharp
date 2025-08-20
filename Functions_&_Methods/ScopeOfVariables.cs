// This program demonstrates scope of variables and parameters
using System;

class Program
{
    static void DisplayNumber(int number)
    {
        // 'number' is a parameter and its scope is within this method
        Console.WriteLine($"Number: {number}");
    }

    static void Main()
    {
        int localVar = 10; // local variable in Main
        DisplayNumber(localVar); // Pass localVar to the method
        // localVar is not accessible outside Main
    }
}

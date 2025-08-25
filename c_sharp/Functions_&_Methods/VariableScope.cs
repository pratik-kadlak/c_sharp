// This program demonstrates variable scope
using System;

class Program
{
    static void Main()
    {
        int outer = 100; // Variable in outer scope

        if (outer > 50)
        {
            int inner = 200; // Variable in inner scope
            Console.WriteLine($"Outer: {outer}, Inner: {inner}");
        }

        // Console.WriteLine(inner); // Error: 'inner' is not accessible here
    }
}

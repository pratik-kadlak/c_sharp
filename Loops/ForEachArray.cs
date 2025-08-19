// This program demonstrates the use of 'foreach' loop to iterate over elements in an array.
using System;

class Program
{
    static void Main()
    {
        // foreach loop with array
        string[] fruits = { "Apple", "Banana", "Cherry" };
        Console.WriteLine("Fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

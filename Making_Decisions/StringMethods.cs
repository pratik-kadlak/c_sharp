// Program demonstrating Trim and ToLower string methods in C#
using System;

class StringMethods
{
    static void Main()
    {
        string input = "  Hello World!  ";
        Console.WriteLine("Original: '" + input + "'");
        Console.WriteLine("Trimmed: '" + input.Trim() + "'");
        Console.WriteLine("Lowercase: '" + input.ToLower() + "'");
    }
}
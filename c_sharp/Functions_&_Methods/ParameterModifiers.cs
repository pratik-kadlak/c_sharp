// This program demonstrates parameter modifiers: ref, out, in
using System;

class Program
{
    // ref modifier allows the method to modify the original variable
    static void ModifyRef(ref int x)
    {
        x += 10;
    }

    // out modifier requires the method to assign a value
    static void AssignOut(out int y)
    {
        y = 20;
    }

    // in modifier passes the parameter as readonly
    static void ShowIn(in int z)
    {
        Console.WriteLine($"Readonly value: {z}");
    }

    static void Main()
    {
        int a = 5;
        ModifyRef(ref a);
        Console.WriteLine($"After ref: {a}");

        int b;
        AssignOut(out b);
        Console.WriteLine($"After out: {b}");

        int c = 30;
        ShowIn(c);
    }
}

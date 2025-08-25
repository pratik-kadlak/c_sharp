// Program demonstrating logical operators in C#
using System;

class LogicalOperators
{
    static void Main()
    {
        bool a = true;
        bool b = false;

        Console.WriteLine("Logical AND: " + (a && b));
        Console.WriteLine("Logical OR: " + (a || b));
        Console.WriteLine("Logical NOT: " + (!a));
    }
}

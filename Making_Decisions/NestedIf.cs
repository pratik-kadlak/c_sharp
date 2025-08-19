// Program demonstrating nested if statements in C#
using System;

class NestedIf
{
    static void Main()
    {
        int number = 15;
        if (number > 10)
        {
            if (number < 20)
            {
                Console.WriteLine("Number is between 10 and 20");
            }
        }
    }
}

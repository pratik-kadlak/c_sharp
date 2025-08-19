// Program demonstrating if-else if-else statement in C#
using System;

class IfElseIfElse
{
    static void Main()
    {
        int score = 85;
        if (score >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (score >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else
        {
            Console.WriteLine("Grade C");
        }
    }
}

// Program demonstrating switch statement in C#
using System;

class SwitchStatement
{
    static void Main()
    {
        Console.WriteLine("Enter a grade (A/B/C):");
        string grade = Console.ReadLine();

        switch (grade.ToUpper())
        {
            case "A":
                Console.WriteLine("Excellent!");
                break;
            case "B":
                Console.WriteLine("Good!");
                break;
            case "C":
                Console.WriteLine("Average!");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }
    }
}

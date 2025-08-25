// Program demonstrating TryParse in C#
using System;

class TryParseExample
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine("You entered: " + result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

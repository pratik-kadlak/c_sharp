// This program demonstrates the use of a 'do-while' loop, which ensures the loop body executes at least once.
using System;

class Program
{
    static void Main()
    {
        // Do-while loop example: Print numbers from 1 to 5
        int i = 1;
        do
        {
            Console.WriteLine($"Number: {i}");
            i++;
        } while (i <= 5);
    }
}

// This program demonstrates the use of a 'while' loop, suitable when the number of iterations is not known in advance.
using System;

class Program
{
    static void Main()
    {
        // While loop example: Print numbers from 1 to 5
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine($"Number: {i}");
            i++;
        }
    }
}

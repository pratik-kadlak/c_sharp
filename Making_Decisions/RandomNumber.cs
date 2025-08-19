// Program demonstrating random number generation in C#
using System;

class RandomNumber
{
    static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(1, 101); // Generates a number between 1 and 100
        Console.WriteLine("Random number: " + number);
    }
}

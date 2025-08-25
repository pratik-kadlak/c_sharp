// Program demonstrating increment, decrement, and modulo operators in C#
using System;

class IncrementDecrementModulo
{
     static void Main()
    {
        // Declare a variable
        int number = 10;

        // Post-increment: value is used first, then incremented
        Console.WriteLine("Post-increment:");
        Console.WriteLine(number++); // Outputs 10, then number becomes 11
        Console.WriteLine("After post-increment, number = " + number); // Outputs 11

        // Pre-increment: value is incremented first, then used
        Console.WriteLine("\nPre-increment:");
        Console.WriteLine(++number); // number becomes 12, then outputs 12

        // Post-decrement: value is used first, then decremented
        Console.WriteLine("\nPost-decrement:");
        Console.WriteLine(number--); // Outputs 12, then number becomes 11
        Console.WriteLine("After post-decrement, number = " + number); // Outputs 11

        // Pre-decrement: value is decremented first, then used
        Console.WriteLine("\nPre-decrement:");
        Console.WriteLine(--number); // number becomes 10, then outputs 10

        // Modulo operation: remainder of division
        int dividend = 17;
        int divisor = 5;
        int remainder = dividend % divisor;
        Console.WriteLine("\nModulo Operation:");
        Console.WriteLine($"{dividend} % {divisor} = {remainder}"); // Outputs 2
    }

}

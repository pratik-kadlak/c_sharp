using System;

public class Calculator
{
    /// <summary>
    /// Adds two integers and returns the result.
    /// </summary>
    /// <param name="a">The first integer to add.</param>
    /// <param name="b">The second integer to add.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        int result = calc.Add(5, 3);
        Console.WriteLine("Sum: " + result);
    }
}

// This program demonstrates the use of 'break' and 'continue' statements to control loop execution flow.
using System;

class Program
{
    static void Main()
    {
        // Demonstrate break and continue in a loop
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Skipping number 5");
                continue; // Skip the rest of the loop for i == 5
            }
            if (i == 8)
            {
                Console.WriteLine("Breaking at number 8");
                break; // Exit the loop when i == 8
            }
            Console.WriteLine($"Number: {i}");
        }
    }
}

// This program demonstrates the use of a two-dimensional array, useful for matrix-like data structures.
using System;

class Program
{
    static void Main()
    {
        // 2D array example
        int[,] grid = { {1, 2}, {3, 4}, {5, 6} };
        Console.WriteLine("2D Array Elements:");
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write($"{grid[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

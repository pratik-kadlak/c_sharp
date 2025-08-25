// This program demonstrates the use of a three-dimensional array, suitable for representing 3D data grids.
using System;

class Program
{
    static void Main()
    {
        // 3D array example
        int[,,] cube = {
            {
                {1, 2},
                {3, 4}
            },
            {
                {5, 6},
                {7, 8}
            }
        };

        Console.WriteLine("3D Array Elements:");
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    Console.Write($"{cube[i, j, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

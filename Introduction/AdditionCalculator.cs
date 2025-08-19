using System;

public class AdditionCalculator {
    public static void Main(string[] args){
        Console.WriteLine("Welcome to the addition calculator");
        Console.WriteLine("Enter Number 1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Addition of the numbers are {num1 + num2}");
    }
}
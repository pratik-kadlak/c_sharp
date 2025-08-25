using System;


public class ConditionalCalculator {
    public static void Main() {
        // TODO: Implement the calculator logic here
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse( Console.ReadLine());
        
        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Choose an operation: +, -, *, /");
        string op = Console.ReadLine();
        
        switch (op){
            case "+":
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;
                case "/":
                if(num2 == 0){
                    Console.WriteLine("Error: Division by zero is not allowed.");
                } else {
                    Console.WriteLine($"Result: {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }
    }
}


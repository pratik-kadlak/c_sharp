using System;

public class StringManipulation {
    public static void Main(string[] args){
        string name = "pratik";
        int age = 24;
        
        // string concatenation
        Console.WriteLine("Name: " + name + " Age: " + age);
        
        // string interpolation
        Console.WriteLine($"Name: {name} Age: {age}");
        
        // string formatting
        Console.WriteLine("Name: {0} Age: {1}", name, age);
        
    }
}
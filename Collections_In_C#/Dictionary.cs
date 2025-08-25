using System;
using System.Collections.Generic;

// ✅ User-defined class to use as dictionary values
public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public override string ToString()
    {
        return $"{Name} ({Department})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ Dictionary declaration and initialization
        Dictionary<int, string> countryCodes = new Dictionary<int, string>
        {
            { 91, "India" },
            { 1, "USA" },
            { 44, "UK" }
        };

        // ✅ Common Dictionary methods
        countryCodes.Add(81, "Japan"); // Add a new key-value pair
        countryCodes[1] = "United States"; // Update value for existing key

        Console.WriteLine("🌍 Country Codes:");
        foreach (var kvp in countryCodes)
        {
            Console.WriteLine($"Code: {kvp.Key}, Country: {kvp.Value}");
        }

        // ✅ Check if a key exists
        if (countryCodes.ContainsKey(91))
        {
            Console.WriteLine("\nIndia is in the dictionary.");
        }

        // ✅ Check if a value exists
        if (countryCodes.ContainsValue("UK"))
        {
            Console.WriteLine("UK is in the dictionary.");
        }

        // ✅ Remove a key-value pair
        countryCodes.Remove(44);

        Console.WriteLine("\nAfter removing UK:");
        foreach (var kvp in countryCodes)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

        // ✅ Using Dictionary with user-defined objects
        Dictionary<int, Employee> employeeDict = new Dictionary<int, Employee>();
        employeeDict.Add(1001, new Employee("Alice", "HR"));
        employeeDict.Add(1002, new Employee("Bob", "IT"));
        employeeDict.Add(1003, new Employee("Charlie", "Finance"));

        Console.WriteLine("\n👥 Employee Directory:");
        foreach (var kvp in employeeDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Info: {kvp.Value}");
        }

        // ✅ Accessing a specific employee
        if (employeeDict.TryGetValue(1002, out Employee emp))
        {
            Console.WriteLine($"\nEmployee with ID 1002: {emp}");
        }

        // ✅ Clearing the dictionary
        employeeDict.Clear();
        Console.WriteLine($"\nEmployee dictionary cleared. Count: {employeeDict.Count}");
    }
}

using System;
using System.Collections; // Required for Hashtable

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ Declaring and initializing a Hashtable
        Hashtable capitals = new Hashtable();

        // ✅ Adding key-value pairs
        capitals.Add("India", "New Delhi");
        capitals.Add("USA", "Washington D.C.");
        capitals.Add("France", "Paris");
        capitals.Add("Japan", "Tokyo");

        // ✅ Accessing values using keys
        Console.WriteLine($"Capital of India: {capitals["India"]}");

        // ✅ Checking if a key exists
        if (capitals.ContainsKey("France"))
        {
            Console.WriteLine("France is in the hashtable.");
        }

        // ✅ Checking if a value exists
        if (capitals.ContainsValue("Tokyo"))
        {
            Console.WriteLine("Tokyo is one of the capitals.");
        }

        // ✅ Removing a key-value pair
        capitals.Remove("USA");
        Console.WriteLine("\nAfter removing USA:");

        // ✅ Iterating through the Hashtable
        foreach (DictionaryEntry entry in capitals)
        {
            Console.WriteLine($"{entry.Key} => {entry.Value}");
        }

        // ✅ Getting the count of items
        Console.WriteLine($"\nTotal countries in hashtable: {capitals.Count}");

        // ✅ Clearing the Hashtable
        capitals.Clear();
        Console.WriteLine($"Hashtable cleared. Count: {capitals.Count}");
    }
}

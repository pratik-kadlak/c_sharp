using System;
using System.Collections; // Required for ArrayList

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ Declaring and initializing an ArrayList
        ArrayList items = new ArrayList();

        // ✅ Adding elements of different types (ArrayList is non-generic)
        items.Add("Apple");
        items.Add(42);
        items.Add(3.14);
        items.Add(true);

        Console.WriteLine("📦 Items in ArrayList:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        // ✅ Accessing elements by index
        Console.WriteLine($"\nFirst item: {items[0]}");

        // ✅ Inserting an item at a specific index
        items.Insert(2, "Banana");
        Console.WriteLine("\nAfter inserting 'Banana' at index 2:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        // ✅ Removing an item by value
        items.Remove("Apple");
        Console.WriteLine("\nAfter removing 'Apple':");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        // ✅ Removing an item by index
        items.RemoveAt(0);
        Console.WriteLine("\nAfter removing item at index 0:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        // ✅ Checking if an item exists
        bool hasBanana = items.Contains("Banana");
        Console.WriteLine($"\nDoes the list contain 'Banana'? {(hasBanana ? "Yes" : "No")}");

        // ✅ Getting the index of an item
        int index = items.IndexOf("Banana");
        Console.WriteLine($"Index of 'Banana': {index}");

        // ✅ Sorting (only works if all items are of the same type)
        ArrayList numbers = new ArrayList { 5, 2, 9, 1 };
        numbers.Sort();
        Console.WriteLine("\n🔢 Sorted numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        // ✅ Reversing the list
        numbers.Reverse();
        Console.WriteLine("\n🔁 Reversed numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        // ✅ Clearing the list
        numbers.Clear();
        Console.WriteLine($"\nList cleared. Count: {numbers.Count}");
    }
}

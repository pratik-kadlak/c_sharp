using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool InStock { get; set; }

    public Product(string name, double price, bool inStock)
    {
        Name = name;
        Price = price;
        InStock = inStock;
    }

    public override string ToString()
    {
        return $"{Name} - ₹{Price} - {(InStock ? "Available" : "Out of Stock")}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // ✅ Declaring and initializing a list of custom objects
        List<Product> products = new List<Product>
        {
            new Product("Laptop", 75000, true),
            new Product("Mouse", 500, true),
            new Product("Keyboard", 1500, false),
            new Product("Monitor", 12000, true),
            new Product("USB Cable", 250, false)
        };

        // ✅ Common List methods
        products.Add(new Product("Webcam", 3000, true)); // Add
        products.Insert(2, new Product("Headphones", 2000, true)); // Insert at index
        products.RemoveAt(4); // Remove item at index
        products.RemoveAll(p => p.Price < 1000); // Remove items based on condition

        Console.WriteLine("📦 Product List:");
        foreach (var p in products)
        {
            Console.WriteLine(p);
        }

        // ✅ Contains and IndexOf
        bool hasMouse = products.Exists(p => p.Name == "Mouse");
        Console.WriteLine($"\nIs 'Mouse' in the list? {(hasMouse ? "Yes" : "No")}");

        int monitorIndex = products.FindIndex(p => p.Name == "Monitor");
        Console.WriteLine($"Index of 'Monitor': {monitorIndex}");

        // ✅ Sorting and reversing
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price)); // Sort by price
        Console.WriteLine("\n🔢 Sorted by Price:");
        products.ForEach(p => Console.WriteLine(p));

        products.Reverse(); // Reverse the list
        Console.WriteLine("\n🔁 Reversed List:");
        products.ForEach(p => Console.WriteLine(p));

        // ✅ Using FindAll with Lambda
        List<Product> inStockProducts = products.FindAll(p => p.InStock);
        Console.WriteLine("\n✅ In-Stock Products:");
        inStockProducts.ForEach(p => Console.WriteLine(p));

        // ✅ Using Predicate explicitly
        Predicate<Product> isExpensive = p => p.Price > 10000;
        List<Product> expensiveProducts = products.FindAll(isExpensive);
        Console.WriteLine("\n💸 Expensive Products (> ₹10,000):");
        expensiveProducts.ForEach(p => Console.WriteLine(p));

        // ✅ Using Any, All
        bool anyOutOfStock = products.Any(p => !p.InStock);
        bool allAffordable = products.All(p => p.Price < 80000);

        Console.WriteLine($"\nAre any products out of stock? {(anyOutOfStock ? "Yes" : "No")}");
        Console.WriteLine($"Are all products affordable (< ₹80,000)? {(allAffordable ? "Yes" : "No")}");

        // ✅ Clearing the list
        products.Clear();
        Console.WriteLine($"\nList cleared. Total products: {products.Count}");
    }
}

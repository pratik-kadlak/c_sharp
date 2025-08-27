using System;

// A simple class with no explicit base class
public class Animal {
    public string Species { get; set; }

    public Animal(string species) {
        Species = species;
    }

    public void Speak() {
        Console.WriteLine($"{Species} makes a sound.");
    }
}

public class Program {
    public static void Main(string[] args) {
        Animal dog = new Animal("Dog");

        dog.Speak(); // Custom method

        // Methods inherited from System.Object
        Console.WriteLine("ToString(): " + dog.ToString()); // Returns class name by default
        Console.WriteLine("GetType(): " + dog.GetType());   // Returns the runtime type
        Console.WriteLine("GetHashCode(): " + dog.GetHashCode()); // Returns a hash code
        Console.WriteLine("Equals(): " + dog.Equals(new Animal("Dog"))); // Compares references
    }
}

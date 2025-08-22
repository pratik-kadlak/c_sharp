using System;

public class Person {
    // Public field: accessible from anywhere
    public string Name;

    // Private field: accessible only within the Person class
    private int age;

    // Public method: can be called from outside the class
    public void SetAge(int a) {
        // Validating age before setting
        if (a >= 0 && a <= 120) age = a;
        else Console.WriteLine("Invalid age.");
        
    }

    // Public method to display details
    public void DisplayInfo() {
        Console.WriteLine($"Name: {Name}, Age: {age}");
    }

    // Private method: cannot be called from outside the class
    private void SecretMethod() {
        Console.WriteLine("This is a private method.");
    }
}

public class Program {
    public static void Main(string[] args){
        Person p = new Person();

        // Accessing public field directly
        p.Name = "Alice";

        // Accessing private field directly is NOT allowed
        // p.age = 30; // ❌ Compile-time error

        // Using public method to set private field
        p.SetAge(30);

        // Displaying info using public method
        p.DisplayInfo();

        // Trying to call private method is NOT allowed
        // p.SecretMethod(); // ❌ Compile-time error
    }
}

using System;

// Base class
public class Animal {
    // 'virtual' allows derived classes to override this method
    public virtual void MakeSound() {
        Console.WriteLine("Generic Animal Sound...");
    }
}

// Derived class Dog overrides MakeSound
public class Dog : Animal {
    // 'override' replaces the base class implementation
    public override void MakeSound() {
        Console.WriteLine("Bhow...");
    }
}

// Derived class Cat also overrides MakeSound
public class Cat : Animal {
    public override void MakeSound() {
        Console.WriteLine("Meow...");
    }
}

public class Program {
    public static void Main(string[] args) {
        // Creating a Dog object and calling MakeSound
        Dog dog = new Dog();
        dog.MakeSound(); // Output: Bhow...
        // This is a direct method call on a Dog instance

        // Polymorphism in action:
        // 'myDog' is declared as type Animal but instantiated as Dog
        Animal myDog = new Dog();
        myDog.MakeSound(); // Output: Bhow...
        // Even though the reference type is Animal, the actual object is Dog
        // Because MakeSound is virtual and overridden in Dog,
        // the Dog's version is called at runtime — this is called **runtime polymorphism**

        // myDog.Sleep(); now i cant use this as this method is not a part of Animal class.
    }
}

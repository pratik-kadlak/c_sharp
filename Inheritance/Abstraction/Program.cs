using System;

// An abstract class is a class that cannot be instantiated directly. 
// Instead, it serves as a blueprint for other classes. 
// It is meant to be inherited by other classes that provide specific 
// implementations for its abstract methods.

// An abstract method is a method that is declared but not defined 
// in the abstract class. It must be overridden in a derived class.

// This allows developers to enforce a structure and behavior across 
// multiple related classes while allowing for flexibility in implementation.

public abstract class Animal {

    public void Move(){
        Console.WriteLine("I am moving...");
    }

    public abstract void MakeSound();

}

public class Dog: Animal {
    public void Sleep(){
        Console.WriteLine("I am sleeping...");
    }
    
    // I have to override the abstract method else gives error
    public override void MakeSound(){
        Console.WriteLine("I am making sound.");
    }
}


public class Program {
    public static void Main(string[] args){
        Dog dog = new Dog();
        dog.Sleep();
        dog.MakeSound();
        
        // error CS0144: Cannot create an instance of the abstract class or interface `Animal'
        // Animal animal  = new Animal();
        // animal.Move();
    }
}
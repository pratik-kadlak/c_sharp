using System;

// Method Hiding is a technique in C# that allows a derived class 
// to define a method with the same name as a method in the base class, 
// effectively hiding the base class method rather than overriding it.
// This is done using the new keyword.


public class Animal {
    public void Move(){
        Console.WriteLine("I am moving...");
    }
}

public class Dog: Animal {
    public new void Move(){
        Console.WriteLine("I am running...");
    }
}

public class Program {
    public static void Main(string[] args){
        Dog dog = new Dog();
        dog.Move();
    }
}
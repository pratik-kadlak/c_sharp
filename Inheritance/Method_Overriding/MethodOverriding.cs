using System;

public class Animal {
    // virtual keyword is necessary for the derived classes 
    // to override this func
    public virtual void Move(){
        Console.WriteLine("I am moving...");
    }
}

public class Dog: Animal {
    // overrides the Move() method
    public override void Move(){
        Console.Write($"Called from Derived class -> ");// to call the Base class method we can use 'base' keyword
        base.Move();
        Console.WriteLine("I am running...");
    }
}

public class Eagle: Animal {
    public override void Move(){
        Console.WriteLine("I am flying...");
    }
}

public class Program {
    public static void Main(string[] args){
        Dog dog = new Dog();
        dog.Move(); // Move() of Dog is called

        Eagle eagle = new Eagle();
        eagle.Move();
    }
}
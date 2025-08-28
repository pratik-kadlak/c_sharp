using System;

public interface IAnimal {
    void Move();
    void MakeSound();
}

public class Dog: IAnimal {
    public void Sleep(){
        Console.WriteLine("I am Sleeping...");
    }
    
    public void Move(){
        Console.WriteLine("I am Moving...");
    }
    
    public void MakeSound(){
        Console.WriteLine("I am Barking...");
    }
}

public class Program {
    public static void Main(string[] args){
        Dog dog = new Dog();
        dog.Sleep();
        dog.MakeSound();
    }
}
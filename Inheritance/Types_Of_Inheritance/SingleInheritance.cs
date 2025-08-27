using System;

// Single Inheritance
// Class A -> Class B

public class Vehicle {
    public void Move(){
        Console.WriteLine("I am Moving...");
    }
}

public class Car: Vehicle {
    public void Drive(){
        Console.WriteLine("I am Driving...");
    }
}

public class Program {
    public static void Main(string[] args){
        Car car = new Car();
        car.Drive();
        car.Move();
    }
}
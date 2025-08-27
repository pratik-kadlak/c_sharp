using System;

// Multilevel Inheritance
// Class A -> Class B -> Class C

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

public class BMW: Car {
    public void CarBrand(){
        Console.WriteLine("I am BMW");
    }
}

public class Program {
    public static void Main(string[] args){
        BMW bmw = new BMW();
        bmw.CarBrand();
        bmw.Drive();
        bmw.Move();
    }
}
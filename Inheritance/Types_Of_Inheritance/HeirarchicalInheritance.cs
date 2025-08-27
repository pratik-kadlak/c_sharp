using System; 

// Hierarchical Inheritance
// Class A -> Class B, Class A -> Class C

// Base class representing a generic vehicle
public class Vehicle {
    public void Move() {
        Console.WriteLine("I am Moving..."); 
    }
}

// Derived class representing a Car, which is a type of Vehicle
public class Car : Vehicle {
    // Method specific to Car
    public void Drive() {
        Console.WriteLine("I am Driving..."); 
    }
}

// Derived class representing an AirPlane, which is also a type of Vehicle
public class AirPlane : Vehicle {
    // Method specific to AirPlane
    public void Fly() {
        Console.WriteLine("I am Flying..."); // Prints a message indicating flying
    }
}

public class Program {
    public static void Main(string[] args) {
        Car car = new Car();
        car.Drive(); // Calls the Drive method specific to Car
        car.Move();  // Calls the inherited Move method from Vehicle
        
        AirPlane airPlane = new AirPlane();
        airPlane.Fly();  // Calls the Fly method specific to AirPlane
        airPlane.Move(); // Calls the inherited Move method from Vehicle
    }
}

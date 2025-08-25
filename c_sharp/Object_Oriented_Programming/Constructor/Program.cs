using System;

// One of the use cases of a Defualt Constructor: UI Forms where the object 
// of a person is created first and the details (properties) are added later

// This is the main class where the program starts
public class Program
{
    public static void Main(string[] args)
    {
        // Creating a Car object using the default constructor
        Car defaultCar = new Car();

        // Creating a Car object using the constructor with one parameter
        Car brandOnlyCar = new Car("Toyota");

        // Creating a Car object using the constructor with two parameters
        Car fullCar = new Car("BMW", "M5");

        // Displaying the car details
        defaultCar.DisplayInfo();
        brandOnlyCar.DisplayInfo();
        fullCar.DisplayInfo();
    }
}

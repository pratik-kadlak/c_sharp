using System;

// This class represents a Car with multiple constructors
public class Car
{
    private string _brand;
    private string _model;

    // Default constructor - sets default values
    public Car()
    {
        _brand = "DefaultBrand";
        _model = "DefaultModel";
    }

    // Constructor with one parameter - sets brand only
    public Car(string brand)
    {
        _brand = brand;
        _model = "UnknownModel";
    }

    // Constructor with two parameters - sets both brand and model
    public Car(string brand, string model)
    {
        _brand = brand;
        _model = model;
    }

    // Method to display car information
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Brand: {_brand}, Model: {_model}");
    }
}

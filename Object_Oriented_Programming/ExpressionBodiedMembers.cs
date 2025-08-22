using System;

// This class demonstrates expression-bodied members in C#
public class Car
{
    private string _brand;
    private string _model;

    // Expression-bodied constructor
    public Car(string brand, string model) => (_brand, _model) = (brand, model);

    // Expression-bodied property getters and setters
    public string Brand
    {
        get => _brand;
        set => _brand = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    // Expression-bodied method
    public void DisplayInfo() => Console.WriteLine($"Brand: {_brand}, Model: {_model}");

    // Expression-bodied ToString override
    public override string ToString() => $"{_brand} {_model}";
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating a Car object using the expression-bodied constructor
        Car car = new Car("Audi", "R8");

        // Using expression-bodied method to display info
        car.DisplayInfo();

        // Using expression-bodied ToString method
        Console.WriteLine(car);
    }
}

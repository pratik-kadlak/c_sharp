using System;

public class Car {
    private string _brand;
    // private string _model;
    // private bool _isLuxury;
    
    public string Brand{
        get { 
            if(IsLuxury) return _brand + " - Luxury Edition";
            else return _brand;
        }
        set {
            if(string.IsNullOrEmpty(value)){
                Console.WriteLine("You entered nothing");
                _brand = "Default";
            } else {
                _brand = value;
            }
        }
    }
    
    // public string Model{get => _model; set => _model = value;}
    // public bool IsLuxury{get => _isLuxury; set => _isLuxury = value;} 
    
    // if we are not modifying the property then we don't even need to have that variable
    public string Model { get; set; }
    public bool IsLuxury { get; set; }
    
    public Car(string brand, string model, bool isLuxury){
        Brand = brand;
        Model = model;
        IsLuxury = isLuxury;
        
        Console.WriteLine($"Car Object Created! Brand: {Brand}, Model: {Model}, IsLuxury: {IsLuxury}");
    }
    
    // method
    public void Drive(){
        Console.WriteLine($"I am {Model} and I am Driving...");
    }

    public void SetDetails(string brand, string model, bool isLuxury){
        Brand = brand;
        Model = model;
        IsLuxury = isLuxury;
    }
    
    
}
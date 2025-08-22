using System;

public class Program {
    public static void Main(string[] args){
        Car bmw = new Car("bmw", "m5", false);
        Car audi = new Car("audi", "r8", true);
        
        Console.WriteLine("Enter a Brand Name: ");
        bmw.Brand = Console.ReadLine();
        
        Console.WriteLine("Enter a Brand Name: ");
        audi.Brand = Console.ReadLine();
        
        Console.WriteLine($"Brand is: {bmw.Brand}");
        Console.WriteLine($"Brand is: {audi.Brand}");

        Car car0 = new Car("", "", false);
        car0.SetDetails("Porsche", "Carrera", true);
        Console.WriteLine($"car0: Brand:{car0.Brand}, Model:{car0.Model}, IsLuxury:{car0.IsLuxury}");
        
    }
}
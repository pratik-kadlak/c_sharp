using System;

public class Rectangle{
    public double height, width;
    
    // Property with only get is read only
    // Property with only set is write only
    public double Area {
        get => height * width;
    }
}

public class Program{
    public static void Main(string[] args){
        Rectangle r = new Rectangle();
        r.height = 4;
        r.width = 20;
        // r.Area = 20; // this line gives error as we area depends on 
                        // height and width so its read only 

        Console.WriteLine($"Area of Rect r: {r.Area}");
    }
}
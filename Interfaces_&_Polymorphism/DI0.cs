using System;

public class Saw {
    public void Use(){
        Console.WriteLine("cutting wood...");
    }
}


public class Hammer {
    public void Use(){
        Console.WriteLine("hammering nails...");
    }
}


public class Builder {
    private Saw _saw;
    private Hammer _hammer;
    
    public Builder() {
        // here Builder class is creating the Tools himself 
        // Builder class is dependent on Saw, and Hammer
        _saw = new Saw();
        _hammer = new Hammer();
    }
    
    public void BuildHouse(){
        _saw.Use();
        _hammer.Use();
        Console.WriteLine("house built...");
    }
}

public class Program {
    public static void Main(string[] args){
        Builder builder = new Builder();
        builder.BuildHouse();
    }
}
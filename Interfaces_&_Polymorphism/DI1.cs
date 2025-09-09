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
    
    // here the depedencies of Saw and Hammer is injected to Builder Class via constructor
    // this is called Constructor Dependency Injection
    public Builder(Saw saw, Hammer hammer) {
        _saw = saw;
        _hammer = hammer;
    }
    
    public void BuildHouse(){
        _saw.Use();
        _hammer.Use();
        Console.WriteLine("house built...");
    }
}

public class Program {
    public static void Main(string[] args){
        Saw saw = new Saw();
        Hammer hammer = new Hammer();
        Builder builder = new Builder(saw, hammer);
        builder.BuildHouse();
    }
}
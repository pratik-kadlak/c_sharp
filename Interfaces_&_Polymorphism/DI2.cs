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
    public Saw Saw { get; set; }
    public Hammer Hammer { get; set; }
    
    public void BuildHouse(){
        Saw.Use();
        Hammer.Use();
        Console.WriteLine("house built...");
    }
}

public class Program {
    public static void Main(string[] args){
        Saw saw = new Saw();
        Hammer hammer = new Hammer();
        Builder builder = new Builder();

        // injecting dependencies using setter methods.
        builder.Saw = saw;
        builder.Hammer = hammer;

        builder.BuildHouse();
    }
}
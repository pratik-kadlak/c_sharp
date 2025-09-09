using System;

public interface IToolUser {
    void SetSaw(Saw saw);
    void SetHammer(Hammer hammer);
}


public class Saw {
    public void Use(){
        Console.WriteLine("cutting woods...");
    }
}


public class Hammer {
    public void Use(){
        Console.WriteLine("hammering nails...");
    }
}


public class Builder: IToolUser {
    private Saw _saw;
    private Hammer _hammer;

    public void SetSaw(Saw saw){
        _saw = saw;
    }

    public void SetHammer(Hammer hammer){
        _hammer = hammer;
    }
    
    public void BuildHouse(){
        _saw.Use();
        _hammer.Use();
        Console.WriteLine("house is complete.");
    }
}

public class Program {
    public static void Main(string[] args){
        Saw saw = new Saw();
        Hammer hammer = new Hammer();
        Builder builder = new Builder();

        builder.SetSaw(saw);
        builder.SetHammer(hammer);
        builder.BuildHouse();

    }

}

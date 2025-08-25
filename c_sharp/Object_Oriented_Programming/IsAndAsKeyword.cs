using System;

// Base class
public class Animal{
    public string Name { get; set; }
}

// Derived class
public class Dog : Animal{
    public void Bark(){
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// Another derived class
public class Cat : Animal{
    public void Meow(){
        Console.WriteLine($"{Name} says: Meow!");
    }
}

public class Program{
    public static void Main(string[] args){
        Animal a1 = new Dog { Name = "Buddy" };
        Animal a2 = new Cat { Name = "Whiskers" };
        Animal a3 = new Animal { Name = "Generic Animal" };

        // Using 'is' keyword to check type before casting
        if (a1 is Dog){
            Console.WriteLine($"{a1.Name} is a Dog.");
            ((Dog)a1).Bark(); // Safe cast after 'is' check
        }

        if (a2 is Cat){
            Console.WriteLine($"{a2.Name} is a Cat.");
            ((Cat)a2).Meow(); // Safe cast after 'is' check
        }

        // Using 'as' keyword to attempt safe casting
        Dog dogRef = a3 as Dog;
        if (dogRef != null) dogRef.Bark();
        else Console.WriteLine($"{a3.Name} is not a Dog.");
        

        // Using 'as' with a valid cast
        Cat catRef = a2 as Cat;
        if (catRef != null) catRef.Meow();
        
    }
}

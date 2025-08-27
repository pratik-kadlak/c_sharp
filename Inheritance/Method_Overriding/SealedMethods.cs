using System;

// A sealed method is a method in a base class that prevents further 
// overriding in derived classes. In other words, once a method is sealed, 
// it cannot be modified by any subclass.
// In C#, a method can only be sealed if it is already overridden in a derived class. 
// This means you cannot seal a method directly in the base class; it must first be an overridden method.

class BaseClass {
    public virtual void ShowMessage(){
        Console.WriteLine("Message from BaseClass");
    }
}
 
class DerivedClass : BaseClass {
    public sealed override void ShowMessage() {
        Console.WriteLine("Message from DerivedClass (Sealed)");
    }
}
 
// This will cause an error because ShowMessage() is sealed in DerivedClass
class SubDerivedClass : DerivedClass{
    public override void ShowMessage() {
        Console.WriteLine("Message from SubDerivedClass");
    } // ❌ ERROR: Cannot override because it's sealed
}

public class Program {
    public static void Main(string[] args){
        SubDerivedClass sdc = new SubDerivedClass();
        sdc.ShowMessage();
    }
}

// Why Use Sealed Methods?
// Sealed methods are useful in specific scenarios where you need to 
// control and protect the behavior of an overridden method.

// When to Use Sealed Methods
// ✔️ Prevent Unintended Changes – 
//     If you have a method that you don't want subclasses to alter, sealing it ensures consistency.
// ✔️ Maintain Security and Integrity – 
//     In sensitive applications like banking software or authentication systems, 
//     sealing methods can prevent unauthorized modifications.
// ✔️ Optimize Performance – The JIT compiler can optimize sealed methods 
//     more efficiently since it knows the method will not be overridden.
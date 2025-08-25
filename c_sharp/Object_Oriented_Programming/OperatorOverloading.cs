// Operator overloading is a feature in C# that allows you to redefine the behavior of operators for custom classes and structs.
// By default, operators like +, -, *, and / work with built-in types such as int, double, and string. 
// However, if you create a custom class (e.g., Vector, Matrix, ComplexNumber), 
// C# does not automatically define how these operators should behave when applied to instances of your class.

/*

Here’s the basic syntax:

public static ReturnType operator Symbol(Type1 operand1, Type2 operand2){
    // Define custom behavior here
    return result;
}

*/

using System;

public class Pair{
    public int _x, _y;
    public Pair(int x, int y){
        _x = x;
        _y = y;
    }
    
    public static Pair operator +(Pair p1, Pair p2){
        return new Pair(p1._x + p2._x, p1._y + p2._y);
    }
}

public class Program {
    public static void Main(string[] args){
        Pair p1 = new Pair(2,3);
        Pair p2 = new Pair(3,2);
        
        Pair res = p1 + p2;
        Console.WriteLine(res._x + " " + res._y);
    }
}

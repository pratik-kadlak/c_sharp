/*

## 🧠 Common Data Types in C#

| Data Type | Description | Example |
|-----------|-------------|---------|
| `int`     | Integer numbers | `int age = 25;` |
| `float`   | Single-precision decimal | `float price = 19.99f;` |
| `double`  | Double-precision decimal | `double distance = 123.456;` |
| `char`    | Single character | `char grade = 'A';` |
| `bool`    | Boolean value | `bool isPassed = true;` |
| `string`  | Sequence of characters | `string name = "Pratik";` |

*/

using System;

public class Datatypes {
    public static void Main(string[] args){
        Console.WriteLine("C# Data Types Example");

        int age = 30;
        float height = 5.9f;
        double weight = 72.5;
        char gender = 'M';
        bool isEmployed = true;
        string name = "Pratik";

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height} ft");
        Console.WriteLine($"Weight: {weight} kg");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Employed: {isEmployed}");
    }
}
using System;

// Base class representing a generic person
public class Person {
    // Public field: accessible from anywhere
    public string Name;

    // Private field: accessible only within this class
    private int age;

    // Protected field: accessible within this class and derived classes
    protected string nationality;

    // Public method to set private field 'age'
    public void SetAge(int value) {
        if (value > 0) {
            age = value;
        }
    }

    // Public method to get private field 'age'
    public int GetAge() {
        return age;
    }

    // Protected method: accessible in derived classes
    protected void SetNationality(string country) {
        nationality = country;
    }

    // Public method to display basic info
    public void DisplayInfo() {
        Console.WriteLine($"Name: {Name}, Age: {age}");
    }
}

// Derived class: Student inherits from Person
public class Student : Person {
    // Public field specific to Student
    public string School;

    // Public method to set protected field 'nationality' from base class
    public void AssignNationality(string country) {
        SetNationality(country); // Allowed because SetNationality is protected
    }

    // Public method to display extended info
    public void DisplayStudentInfo() {
        DisplayInfo(); // Calls base class method
        Console.WriteLine($"School: {School}, Nationality: {nationality}"); // Accessing protected field
    }
}

// Main program class
public class Program {
    public static void Main(string[] args) {
        // Create a Student object
        Student student = new Student();

        // Accessing public members directly
        student.Name = "Pratik";
        student.School = "Tech University";

        // Accessing private member via public methods
        student.SetAge(25);

        // Accessing protected member via public method in derived class
        student.AssignNationality("Indian");

        // Display all information
        student.DisplayStudentInfo();

        // ❌ The following lines would cause compile-time errors:
        // student.age = 25;         // 'age' is private
        // student.nationality = "Indian"; // 'nationality' is protected
    }
}

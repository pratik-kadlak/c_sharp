using System; // Importing the System namespace to use Console and other basic classes

// When Is Constructor Inheritance Essential?

// When the base class has a constructor with parameters
// If the base class (Person) requires parameters (name, age), 
// the derived class (Employee) must call the base constructor using : base(...).

// When the base class performs important setup
// If the base constructor contains logic (e.g., logging, validation, resource allocation),
// skipping it would mean the derived class object is incompletely or incorrectly initialized.

// When you want to reuse initialization logic
// Instead of duplicating code in every derived class, 
// you centralize it in the base constructor and call it via inheritance.


// Base class representing a Person
public class Person {
    // Public properties with private setters (read-only outside the class)
    public string Name { get; private set; }
    public int Age { get; private set; }

    // Constructor of the base class
    public Person(string name, int age) {
        Name = name; // Assigning name to the property
        Age = age;   // Assigning age to the property
        Console.WriteLine("Person Constructor Called."); // Message to show constructor execution
    }

    // Public method to display personal info
    public void DisplayPersonalInfo() {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Derived class representing an Employee, which inherits from Person
public class Employee : Person {
    // Additional properties specific to Employee
    public string JobTitle { get; private set; }
    public int Salary { get; private set; }

    // Constructor of the derived class
    // It uses `: base(name, age)` to call the constructor of the base class
    public Employee(string name, int age, string jobTitle, int salary) : base(name, age) {
        JobTitle = jobTitle; // Assigning job title
        Salary = salary;     // Assigning salary
        Console.WriteLine("Employee Constructor Called."); // Message to show constructor execution
    }

    // Method to display employee-specific info
    public void DisplayEmpInfo() {
        DisplayPersonalInfo(); // Calls method from base class
        Console.WriteLine($"JobTitle: {JobTitle}, Salary: {Salary}");
    }
}

// Main program class
public class Program {
    public static void Main(string[] args) {
        // Creating an instance of Employee
        // This will first call the Person constructor, then the Employee constructor
        Employee emp = new Employee("Joe", 25, "SDE", 150000);

        // Displaying all employee information
        emp.DisplayEmpInfo();
    }
}

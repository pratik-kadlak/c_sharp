
using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string JobTitle { get; set; }
    public int Salary { get; set; }

    // Constructor with optional parameters
    public Employee(string firstName = "Unknown", string lastName = "Unknown", string jobTitle = "Not Assigned", int salary = 0)
    {
        FirstName = firstName;
        LastName = lastName;
        JobTitle = jobTitle;
        Salary = salary;
    }

    // Method with optional parameters
    public void UpdateJobDetails(string jobTitle = "Intern", int salary = 30000)
    {
        JobTitle = jobTitle;
        Salary = salary;
    }

    // Method using named parameters
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Job Title: {JobTitle}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Using constructor with default values
        Employee emp1 = new Employee();
        emp1.DisplayDetails();
        Console.WriteLine();

        // Using constructor with named parameters
        Employee emp2 = new Employee(firstName: "Alice", lastName: "Johnson", salary: 90000);
        emp2.DisplayDetails();
        Console.WriteLine();

        // Using method with default parameters
        emp2.UpdateJobDetails(); // Will set jobTitle to "Intern" and salary to 30000
        emp2.DisplayDetails();
        Console.WriteLine();

        // Using method with named parameters
        emp2.UpdateJobDetails(salary: 120000, jobTitle: "Senior Developer");
        emp2.DisplayDetails();
    }
}

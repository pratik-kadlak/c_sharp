using System;

public partial class Employee
{
    // Partial method implementation
    partial void DisplayPersonalDetails()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}");
    }

    // Partial method implementation
    partial void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {JobTitle}, Salary: {Salary}");
    }
}

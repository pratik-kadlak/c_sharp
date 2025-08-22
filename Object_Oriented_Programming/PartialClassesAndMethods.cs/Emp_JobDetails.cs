using System;

public partial class Employee
{
    public string JobTitle { get; set; }
    public int Salary { get; set; }

    // Partial method declaration
    partial void DisplayJobDetails();

    // Public method that calls the partial method internally
    public void ShowJobDetails()
    {
        DisplayJobDetails(); // Allowed because it's inside the same class
    }
}

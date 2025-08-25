using System;

public partial class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Partial method declaration
    partial void DisplayPersonalDetails();

    // Public method that calls the partial method internally
    public void ShowPersonalDetails()
    {
        DisplayPersonalDetails(); // Allowed because it's inside the same class
    }
}

// Partial Classes allow a class definition to be split across multiple files. 
// This is particularly useful in large projects where different developers might work on different aspects of the same class.

// Similarly, Partial Methods enable the declaration of method signatures in one part of a class 
// while allowing the implementation to be optional in another. This can help create cleaner and more maintainable code.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.FirstName = "Alice";
        emp.LastName = "Smith";
        emp.JobTitle = "QA Engineer";
        emp.Salary = 120000;

        emp.ShowPersonalDetails(); // Calls internal partial method
        emp.ShowJobDetails();      // Calls internal partial method
    }
}

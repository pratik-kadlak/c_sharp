using System; 

public class Person {
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age) {
        Name = name; 
        Age = age;   
        Console.WriteLine("Person Constructor Called."); 
    }

    public void DisplayPersonalInfo() {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Person {
    public string JobTitle { get; private set; }
    public int Salary { get; private set; }

    public Employee(string name, int age, string jobTitle, int salary) : base(name, age) {
        JobTitle = jobTitle;
        Salary = salary;    
        Console.WriteLine("Employee Constructor Called."); 
    }

    public void DisplayEmpInfo() {
        DisplayPersonalInfo(); 
        Console.WriteLine($"JobTitle: {JobTitle}, Salary: {Salary}");
    }
}

public class Manager: Employee {
    public int TeamSize { get; private set; }

    public Manager(string name, int age, string jobTitle, int salary, int teamSize): base(name, age, jobTitle, salary){
        TeamSize = teamSize;
        Console.WriteLine("Manager Constructor Called.");
    }

    public void DisplayManagerInfo(){
        DisplayEmpInfo();
        Console.WriteLine($"TeamSize: {TeamSize}");
    }
}

public class Program {
    public static void Main(string[] args) {
        // Employee emp = new Employee("Joe", 25, "SDE", 150000);
        // emp.DisplayEmpInfo();
        
        Manager mgr = new Manager("Earl", 34, "manager", 240000, 7);
        mgr.DisplayManagerInfo();
        
    }
}

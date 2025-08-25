using System;

// throw is used to manually raise exceptions when something goes wrong.
// Helps enforce rules and signal errors clearly.

class Program {
    static void ValidateAge(int age) {
        if (age < 0) {
            throw new ArgumentOutOfRangeException("Age cannot be negative.");
        }
    }

    static void Main() {
        try {
            ValidateAge(-5);
        } catch (ArgumentOutOfRangeException ex) {
            Console.WriteLine("Exception thrown: " + ex.Message);
        }
    }
}

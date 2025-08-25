using System;
using System.Diagnostics;

// Debug.WriteLine is useful for logging during development.
// Helps trace issues without affecting production output.

class Program {
    static void Main() {
        try {
            int.Parse("abc");
        } catch (FormatException ex) {
            Debug.WriteLine("Debug log: " + ex.Message); // Only visible in debug mode
            Console.WriteLine("Handled error.");
        }
    }
}

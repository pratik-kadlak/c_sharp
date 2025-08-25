
using System;

// try: Code that might throw an exception.
// catch: Handles specific exceptions.
// finally: Runs regardless of whether an exception occurred (e.g., for cleanup).

class Program {
    static void Main() {
        try {
            int number = int.Parse("abc"); // Will throw FormatException
        } catch (FormatException ex) {
            Console.WriteLine("Caught a format exception: " + ex.Message);
        } finally {
            Console.WriteLine("This block always runs, even if there's an exception.");
        }
    }
}

using System;

// Exceptions bubble up the call stack until caught.
// The stack trace shows where the error originated, helping with debugging.

class Program {
    static void Level1() {
        Level2();
    }

    static void Level2() {
        Level3();
    }

    static void Level3() {
        throw new InvalidOperationException("Something went wrong at Level3.");
    }

    static void Main() {
        try {
            Level1();
        } catch (Exception ex) {
            Console.WriteLine("Exception caught: " + ex.Message);
            Console.WriteLine("Stack trace:\n" + ex.StackTrace);
        }
    }
}

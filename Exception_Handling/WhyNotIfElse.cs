using System;

// if-else is good for predictable conditions.
// try-catch is necessary for unexpected runtime errors like parsing, file access, etc.

class Program {
    static void Main() {
        string input = "abc";

        // You can't use if-else to catch parsing errors reliably
        if (int.TryParse(input, out int result)) {
            Console.WriteLine("Parsed successfully: " + result);
        } else {
            Console.WriteLine("Invalid input.");
        }

        // But if you use int.Parse, you must use try-catch
        try {
            int number = int.Parse(input); // Throws FormatException
        } catch (FormatException ex) {
            Console.WriteLine("Handled with try-catch: " + ex.Message);
        }
    }
}

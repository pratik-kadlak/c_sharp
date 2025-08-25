using System;

// Catching specific exceptions helps you respond appropriately.
// A final catch (Exception) is useful for unexpected errors.

class Program {
    static void Main() {
        try {
            string input = null;
            int number = int.Parse(input); // NullReferenceException or FormatException
        } catch (FormatException ex) {
            Console.WriteLine("Format issue: " + ex.Message);
        } catch (ArgumentNullException ex) {
            Console.WriteLine("Null input: " + ex.Message);
        } catch (Exception ex) {
            Console.WriteLine("General error: " + ex.Message);
        }
    }
}

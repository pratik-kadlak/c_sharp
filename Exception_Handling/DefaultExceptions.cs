using System;

// .NET provides rich exception types like IndexOutOfRangeException, NullReferenceException, etc.
// These help you diagnose issues quickly without writing custom error logic.


class Program {
    static void Main() {
        try {
            int[] arr = new int[3];
            Console.WriteLine(arr[5]); // IndexOutOfRangeException
        } catch (Exception ex) {
            Console.WriteLine("Default exception caught: " + ex.GetType().Name);
        }
    }
}

using System;
using System.IO;

public class Program {
    public static void Main(string[] args) {
        // we can give path like this: "C:\\Logs" as \ is escape char so we write it twice
        string directoryPath = @"C:\Logs"; // we can also use `@` before string to tell take this string as it 
                                           // is without any escape characters.
        string filePath = Path.Combine(directoryPath, "log.txt");
        string message = "this is a log entry\n";
        
        if(!Directory.Exists(directoryPath)){
            Directory.CreateDirectory(directoryPath);
        }
        
        File.AppendAllText(filePath, message);
        Console.ReadKey();
    }
}
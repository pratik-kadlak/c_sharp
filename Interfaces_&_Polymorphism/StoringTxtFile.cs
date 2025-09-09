using System;
using System.IO;

public class Program {
    public static void Main(string[] args){
        // writes the text in log.txt and it creates it if not already exist
        File.AppendAllText("log.txt", "Hello World!\n");
        Console.ReadKey();
    }
}
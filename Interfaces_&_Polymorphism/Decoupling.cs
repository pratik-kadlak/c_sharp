using System;
using System.IO;

// What Is Decoupling?
// Decoupling means separating components so they are independent and interchangeable. In software design, it helps make code:
// Easier to maintain
// Easier to test
// More flexible and reusable

// How Decoupling Is Used in This Program
// 1. Interface-Based Design
// The ILogger interface defines a contract.
// Application depends on ILogger, not on any specific implementation like FileLogger or DatabaseLogger.
// 2. Dependency Injection
// The logger is passed into Application via its constructor.
// This allows switching loggers without changing the Application class.
// 3. Swappable Implementations
// You can add new loggers (e.g., CloudLogger, EventLogger) without modifying Application.

// Interface that defines a logging contract
public interface ILogger {
    void Log(string message);
}

// Concrete implementation that logs messages to a file
public class FileLogger : ILogger {
    public void Log(string message) {
        string directory = @"C:/Log";
        string filePath = Path.Combine(directory, "log.txt");

        // Create directory if it doesn't exist
        if (!Directory.Exists(directory)) {
            Directory.CreateDirectory(directory);
        }

        // Append message to log file
        File.AppendAllText(filePath, message + "\n");
    }
}

// Another implementation that logs messages to a database (simulated)
public class DatabaseLogger : ILogger {
    public void Log(string message) {
        // Simulate logging to a database
        Console.WriteLine($"Logging to database. {message}");
    }
}

// Application class that performs work and logs messages
public class Application {
    private readonly ILogger _logger;

    // Constructor accepts any ILogger implementation
    public Application(ILogger logger) {
        _logger = logger;
    }

    // Method that performs work and logs progress
    public void DoWork() {
        _logger.Log("Work Started.");
        // Simulate work
        _logger.Log("Work Done!");
    }
}

// Entry point of the program
public class Program {
    public static void Main(string[] args) {
        // Use FileLogger
        ILogger fileLogger = new FileLogger();
        Application app = new Application(fileLogger);
        app.DoWork();

        // Switch to DatabaseLogger
        ILogger dbLogger = new DatabaseLogger();
        app = new Application(dbLogger);
        app.DoWork();
    }
}

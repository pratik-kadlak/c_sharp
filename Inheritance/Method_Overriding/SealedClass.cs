using System;

// Why Use sealed Here?
// Prevent misuse: You don’t want other developers to inherit and override config loading logic.
// Ensure consistency: Configuration should be centralized and predictable.
// Security: Prevent accidental or malicious changes to how settings are retrieved.

// A sealed class to prevent inheritance and ensure consistent configuration behavior
public sealed class ConfigManager
{
    private readonly Dictionary<string, string> _settings;

    public ConfigManager()
    {
        // Simulating loading configuration from a file or environment
        _settings = new Dictionary<string, string>
        {
            { "AppName", "InventorySystem" },
            { "Version", "1.0.0" },
            { "Environment", "Production" }
        };
    }

    public string GetSetting(string key)
    {
        return _settings.ContainsKey(key) ? _settings[key] : "Not Found";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ConfigManager config = new ConfigManager();

        Console.WriteLine("App Name: " + config.GetSetting("AppName"));
        Console.WriteLine("Version: " + config.GetSetting("Version"));
        Console.WriteLine("Environment: " + config.GetSetting("Environment"));
        Console.WriteLine("Database: " + config.GetSetting("Database")); // Key not found
    }
}

using System;

public class BankAccount {
    // Private field to store balance
    private decimal _balance;

    // Read-only property: can only be read, not written to
    public decimal Balance { get => _balance;}

    // Write-only property: can only be written to, not read
    public decimal Deposit {
        set {
            if (value > 0)_balance += value;
            else Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to display current balance
    public void ShowBalance() {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

public class Program {
    public static void Main(string[] args) {
        BankAccount account = new BankAccount();

        // Using write-only property to deposit money
        account.Deposit = 500.75m;
        account.Deposit = -100; // Invalid deposit

        // Using read-only property to get balance
        account.ShowBalance();

        // Direct access to Deposit (write-only) is not allowed for reading
        // Console.WriteLine(account.Deposit); // ❌ Compile-time error

        // Direct access to Balance (read-only) is not allowed for writing
        // account.Balance = 1000; // ❌ Compile-time error
    }
}

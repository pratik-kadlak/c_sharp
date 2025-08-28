using System;

// This is an interface — like a rulebook.
// It says: "Any class that wants to be a payment processor must have a method called ProcessPayment."
public interface IPaymentProcessor {
    void ProcessPayment(decimal amount);
}

// This class follows the rulebook (interface) and knows how to process credit card payments.
public class CreditCardProcessor : IPaymentProcessor {
    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

// This class also follows the rulebook and knows how to process PayPal payments.
public class PaypalProcessor : IPaymentProcessor {
    public void ProcessPayment(decimal amount) {
        Console.WriteLine($"Processing paypal payment of {amount}");
    }
}

// This class is like a shop or service that handles payments.
// It doesn't care how the payment is processed — it just uses whatever processor it's given.
public class PaymentService {
    private readonly IPaymentProcessor _processor; // This is the cashier (credit card or PayPal)

    // When we create a PaymentService, we give it a cashier (payment processor)
    public PaymentService(IPaymentProcessor processor) {
        _processor = processor;
    }

    // This method tells the cashier to process the payment
    public void ProcessOrderPayment(decimal amount) {
        _processor.ProcessPayment(amount);
    }
}

// This is the main part of the program where everything runs
public class Program {
    public static void Main(string[] args) {
        // First, we create a credit card processor
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();

        // Then we give it to the payment service (shop)
        PaymentService paymentService = new PaymentService(creditCardProcessor);

        // The shop tells the credit card processor to process a payment of 3.99
        paymentService.ProcessOrderPayment(3.99m);

        // Now we create a PayPal processor
        IPaymentProcessor paypalProcessor = new PaypalProcessor();

        // We give the PayPal processor to the shop
        paymentService = new PaymentService(paypalProcessor);

        // The shop tells the PayPal processor to process a payment of 12.99
        paymentService.ProcessOrderPayment(12.99m);
    }
}

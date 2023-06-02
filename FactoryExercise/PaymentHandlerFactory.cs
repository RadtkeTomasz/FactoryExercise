using static Payment;

public static class PaymentHandlerFactory
{
    public static IPaymentGateway GeneratePaymentHandler(Payment payment)
    {
        switch (payment.Provider)
        {
            case PaymentServiceProvider.Bank1 : return new Bank1();
            case PaymentServiceProvider.Bank2 : return new Bank2();
            default: throw new InvalidOperationException("No fitting service provider found.");
        }
    }
}
using static Payment;

public static class PaymentApiHelper : IPayment
{
    public static string RealisePayment(Payment payment)
    {
        return SendApiRequestWithPayment(payment.Provider, payment.Id, payment.TotalAmount);
    }

    private string SendApiRequestWithPayment(PaymentServiceProvider provider, Guid paymentId, decimal totalAmount)
    {
        
        switch (provider)
        {
            case PaymentServiceProvider.Bank1: return "Bank1API";
            case PaymentServiceProvider.Bank2: return "Bank2API";
            case PaymentServiceProvider.BLIK: return "BLIKAPI";
            case PaymentServiceProvider.Przelewy24: return "Przelewy24API";
            default: throw new NotImplementedException("Payment provider not found");
        }
    }
}

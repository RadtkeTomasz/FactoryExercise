public class Przelewy24 : IPaymentGateway
{
    public void RealisePayment(Payment payment)
    {
        Console.WriteLine("Przelewy24 nie pobiera prowizji.");
    }
}
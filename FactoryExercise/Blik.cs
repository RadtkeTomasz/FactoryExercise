public class Blik : IPaymentGateway
{
    public void RealisePayment(Payment payment)
    {
        Console.WriteLine("Blik nie pobiera prowizji.");
    }
}
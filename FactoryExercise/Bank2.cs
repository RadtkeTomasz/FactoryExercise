public class Bank2 : IPaymentGateway
{
    public void RealisePayment(Payment payment)
    {
        Console.WriteLine($"Bank 2 zabrał 1.5% prowizji, czyli {payment.TotalAmount * 0.015M} PLN");
    }
}

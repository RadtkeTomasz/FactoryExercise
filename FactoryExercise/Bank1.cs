public class Bank1 : IPaymentGateway
{
    public void RealisePayment(Payment payment)
    {
        if (payment.TotalAmount > 50.00M)
        {
            Console.WriteLine($"Bank 1 zabrał 1.5% prowizji, czyli {payment.TotalAmount * 0.015M} PLN");
        }
        Console.WriteLine($"Bank 1 zabrał 2% prowizji, czyli {payment.TotalAmount * 0.02M} PLN");
    }
}

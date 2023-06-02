using static Payment;

var ProductsInBasket = new List<Product>()
{ new Product { Description = "A",Name = "ProductA", Price = 20.00M },
  new Product { Description = "B", Name = "ProductB", Price = 50.00M},
 new Product { Description = "C", Name = "ProductC", Price = 40.00M }};

var payment = new Payment(PaymentServiceProvider.Bank1, "SomeDescription", ProductsInBasket.Sum(p => p.Price));


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

public class Bank2 : IPaymentGateway
{
    public void RealisePayment(Payment payment)
    {
        Console.WriteLine($"Bank 2 zabrał 1.5% prowizji, czyli {payment.TotalAmount * 0.015M} PLN");
    }
}

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
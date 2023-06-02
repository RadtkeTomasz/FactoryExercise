using static Payment;

var ProductsInBasket = new List<Product>()
{ new Product { Description = "A",Name = "ProductA", Price = 20.00M },
  new Product { Description = "B", Name = "ProductB", Price = 50.00M},
 new Product { Description = "C", Name = "ProductC", Price = 40.00M }};

var payment = new Payment(PaymentServiceProvider.Bank1, "SomeDescription", ProductsInBasket.Sum(p => p.Price));

var handler = PaymentHandlerFactory.GeneratePaymentHandler(payment);
handler.RealisePayment(payment);

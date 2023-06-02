using static Payment;

var ProductsInBasket = new List<Product>()
{ new Product { Description = "A",Name = "ProductA", Price = 20.00M },
  new Product { Description = "B", Name = "ProductB", Price = 50.00M},
 new Product { Description = "C", Name = "ProductC", Price = 40.00M }};

var payment = PaymentFactory.GeneratePayment(PaymentServiceProvider.Bank1, "SomeDescription", ProductsInBasket.Sum(p => p.Price));
var apiHelper = new PaymentApiHelper();
apiHelper.RealisePayment(payment);

public class Payment
{
    protected Payment(PaymentServiceProvider serviceProvider, string description, decimal total)
    {
        this.Description = description;
        this.Provider = serviceProvider;
        this.Description = description;
        this.TotalAmount = total;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public PaymentServiceProvider Provider { get; set; }
    public string Description { get; set; }
    public decimal TotalAmount { get; set; }

    public static class PaymentFactory
    {
        public static Payment GeneratePayment(PaymentServiceProvider serviceProvider, string description, decimal totalAmount)
        {
            return new Payment(serviceProvider, description, totalAmount);
        }
    }

    public enum PaymentServiceProvider
    {
        Bank1,
        Bank2,
        BLIK,
        Przelewy24
    }
}

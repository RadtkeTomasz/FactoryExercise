public class Payment
{
    public Payment(PaymentServiceProvider serviceProvider, string description, decimal total)
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

    

    public enum PaymentServiceProvider
    {
        Bank1,
        Bank2,
        BLIK,
        Przelewy24
    }
}

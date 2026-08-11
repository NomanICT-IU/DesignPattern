namespace FactoryPattern;

public class BkashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ৳{amount} using bKash");
    }
}

namespace FactoryPattern;

public class RocketPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid ৳{amount} using Rocket");
    }
}

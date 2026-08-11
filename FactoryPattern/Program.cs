using FactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IOrderCheckoutService checkoutService = new OrderService();

        checkoutService.Checkout(PaymenType.Bkash, 1000);

     
        checkoutService.Checkout(PaymenType.Rocket, 2000);

        Console.ReadKey();

    }
}
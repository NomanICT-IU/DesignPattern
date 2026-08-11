namespace FactoryPattern;

public interface IOrderCheckoutService
{
    public void Checkout(PaymenType paymentType, decimal amount);
}
